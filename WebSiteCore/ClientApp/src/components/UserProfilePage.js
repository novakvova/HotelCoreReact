import React, { Component } from 'react';
import UserProfileForm from './UserProfileForm';

class UserProfilePage extends Component {
	render() {
		return (
			<div className="row">
				<div className="col-md-4 col-md-offset-4">
					<UserProfileForm />
				</div>
			</div>);
	}
}
export default UserProfilePage;