using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TestDbQueryConsole.Entities
{
    [Table("vAuthorArticleCount")]
    public class AuthorArticleCount
    {
        public string Name { get; private set; }
        public int ArticleCount { get; private set; }
    }

    /*
    
    
CREATE VIEW [dbo].[vAuthorArticleCount]
AS 
SELECT  a.Name,
  Count(r.Id) as ArticleCount
from tblAuthors a
  JOIN tblArticles r on r.Id = a.Id
GROUP BY a.Name
     */
}
