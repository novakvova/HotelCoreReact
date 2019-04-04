using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteCore.DAL.Entities.SqlViews;
using WebSiteCore.ViewModels;

namespace WebSiteCore.DAL.Entities
{
    public class EFDbContext : IdentityDbContext<DbUser>
    {
        public EFDbContext(DbContextOptions<EFDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<ConvenienceType> ConvenienceTypes { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<BoardType> BoardTypes { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<ApartmentImage> ApartmentImages { get; set; }

        public virtual DbQuery<VApartmentData> VApartmentsData { get; set; }
        public virtual DbQuery<VApartment> VApartments { get; set; }
        public virtual DbQuery<VApartApartImg> VApartApartImg { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<VApartmentData>().ToView("vApartmentsData");
            modelBuilder.Query<VApartment>().ToView("vApartments");

            // [Asma Khalid]: Register store procedure custom object.  
            //modelBuilder.Query<ApartmentSPViewModel>();

            base.OnModelCreating(modelBuilder);
        }


        #region Storeage Procedure by DB 
        public async Task<List<ApartmentSPViewModel>> GetApartmentsByRange(int skip, int take)
        {
            // Initialization.  
            List<ApartmentSPViewModel> lst = null;
            try
            {
                string connString = @"Data Source=DESKTOP-BLC5I62;Initial Catalog=HotelTereshko;User ID=test;Password=123456;";
                string sprocname = "[dbo].[spFetchApartments]";
                string jsonOutputParam = "@JSONOutput";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sprocname, conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        DbParameter paramSkip = cmd.CreateParameter();
                        paramSkip.ParameterName = "@From";
                        paramSkip.DbType = System.Data.DbType.Int32;
                        paramSkip.Direction = ParameterDirection.Input;
                        paramSkip.Value = skip;
                        cmd.Parameters.Add(paramSkip);

                        DbParameter paramTake = cmd.CreateParameter();
                        paramTake.ParameterName = "@To";
                        paramTake.DbType = System.Data.DbType.Int32;
                        paramTake.Direction = ParameterDirection.Input;
                        paramTake.Value = take;
                        cmd.Parameters.Add(paramTake);

                        //DbParameter paramJSONOotput = cmd.CreateParameter();
                        //paramJSONOotput.ParameterName = "@JSONOutput";
                        //paramJSONOotput.DbType = System.Data.DbType.String;
                        //paramJSONOotput.Direction = ParameterDirection.Output;
                        //cmd.Parameters.Add(paramJSONOotput);

                        cmd.Parameters.Add(jsonOutputParam, SqlDbType.VarChar, -1).Direction = ParameterDirection.Output;

                        // Execute the command
                        cmd.ExecuteNonQuery();

                        // Get the values
                        string json = $"{cmd.Parameters[jsonOutputParam].Value.ToString()}";
                        json = json.Replace(@"\", string.Empty);
                        var res = JsonConvert.DeserializeObject<ApartmentSPViewModel>(json);
                    }
                }


                //this.Clients.Count();
                //string sqlQuery = "[dbo].[spFetchApartments]";
                //DbConnection connection = this.Database.GetDbConnection();
                //DbCommand cmd = connection.CreateCommand();
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandText = sqlQuery;
                //cmd.Connection = connection;

                //DbParameter paramSkip = cmd.CreateParameter();
                //paramSkip.ParameterName = "@From";
                //paramSkip.DbType = System.Data.DbType.Int32;
                //paramSkip.Direction = ParameterDirection.Input;
                //paramSkip.Value = skip;
                //cmd.Parameters.Add(paramSkip);

                //DbParameter paramTake = cmd.CreateParameter();
                //paramTake.ParameterName = "@To";
                //paramTake.DbType = System.Data.DbType.Int32;
                //paramTake.Direction = ParameterDirection.Input;
                //paramTake.Value = skip;
                //cmd.Parameters.Add(paramTake);

                ////connection.Open();

                //var jsonResult = new StringBuilder();
                //var reader = cmd.ExecuteReader();
                //if (!reader.HasRows)
                //{
                //    jsonResult.Append("[]");
                //}
                //else
                //{
                //    while (reader.Read())
                //    {
                //        //var data = reader.GetValue(0).ToString();
                //        jsonResult.Append(reader.GetValue(0).ToString());
                //    }
                //}
                //var res= jsonResult.ToString();


                ////var data = this.Apartments.FromSql(sqlQuery).OfType<ApartmentSPViewModel>().ToList();
                ////var res = this.Query<ApartmentSPViewModel>().FromSql(sqlQuery);
                ////var res = this.Database.ExecuteSqlCommand(sqlQuery,     
                ////    new SqlParameter("@From", skip),
                ////    new SqlParameter("@To", take));
                ////var res = this.Database.ExecuteSqlCommand(sqlQuery);
                ////var data3 = this.Apartments.FromSql(sqlQuery).Select(a => );


            }
            catch (Exception ex)
            {
                throw ex;
            }
            // Info.  
            return lst;
        }
        #endregion
    }
}
