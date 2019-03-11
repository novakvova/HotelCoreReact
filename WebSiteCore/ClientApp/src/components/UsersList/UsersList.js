import React from 'react';
import axios from 'axios';

class UsersList extends React.Component {

    state={
        users: []
    }
    componentDidMount() {
        axios.get('https://localhost:44342/api/ViewUsers')
        .then(res => {
            console.log(res);
          const users = res.data;
          this.setState({ users });
            })
        }
    render() {
        return (
            <div className='container'style={{marginTop:'25px'}}>
                <h1>
                    {this.users}
                    Test Users
                </h1>
            </div>

        )
    }
}
export default UsersList