import React, { Component } from 'react';
import classnames from 'classnames';
import PropTypes from 'prop-types';

class UserProfileForm extends Component {
  state = {
    name: '',
    surname: '',
    passportSerNum: '',
    gender: true,
    age: 18,
    done: false,
    isLoading: false,
    errors: {}
  }

  setStateByErrors = (name, value) => {
    if (!!this.state.errors[name]) {
      let errors = Object.assign({}, this.state.errors);
      delete errors[name];
      this.setState(
        {
          [name]: value,
          errors
        }
      )
    } else {
      this.setState({
        [name]: value
      })
    }
  }

  handleChange = (e) => {
    this.setStateByErrors(e.target.name, e.target.value);
  }

  onSubmitForm = (e) => {
    e.preventDefault();

    let errors = {};
    if (this.state.name === '') {
      errors.name = 'Can`t be empty';
    }
    if (this.state.surname === '') {
      errors.surname = 'Can`t be empty';
    }
    if (this.state.age < 18) {
      errors.age = 'Must be adult';
    }
    if (this.state.passwordSerNum === 'Can`t be empty') {
      errors.passportSerNum = 'Can`t be empty';
    }

    const invalid = Object.keys(errors).length === 0;
    if (invalid) {
      const { name, surname, age, passportSerNum, gender} = this.state;
      this.setState({ isLoading: true });
      //this.props.setProfile()
      // .then(
      //   () => this.setState({ done: true }),
      //   (err) => this.setState({ errors: err.response.data, isLoading: false })
      // )
    } else {
      this.setState({ errors });
    }
  }

  render() {
    const { errors, isLoading } = this.state;
    const form = (
      <form onSubmit={this.onSubmitForm}>
        <div clasName="center">
          <h1>User profile</h1>
        </div>
        {
          !!errors.invalid ?
            <div className="alert alert-danger">
              <strong>Warning!</strong> {errors.invalid}
            </div> : ''
        }
        <div className={classnames("form-group", { 'has-error': !!errors.name })}>
          <label htmlFor="login">Name</label>
          <input type="text"
            className="form-control"
            id="name"
            name="name"
            value={this.state.name}
            onChange={this.handleChange}></input>
          {!!errors.name ? <span clasName="help-block">{errors.name}</span> : ''}
        </div>
        <div className="form-group">
          <label>Surname</label>
          <input type="text"
            className="form-control"
            id="surname"
            name="surname"
            value={this.state.surname}
            onChange={this.handleChange}></input>
        </div>
        <div className="form-group">
          <label>Serial number of the passport</label>
          <input type="text"
            className="form-control"
            id="passportSerNum"
            name="passportSerNum"
            value={this.state.passportSerNum}
            onChange={this.handleChange}></input>
        </div>
        <div className="form-group">
          <label>Age</label>
          <input type="text"
            className="form-control"
            id="age"
            name="age"
            value={this.state.age}
            onChange={this.handleChange}></input>
        </div>
        <div className="form-group">
          <label>Gender</label>
          <input type="radio"
            className="form-control"
            id="male"
            name="gender"
            value="true"
            checked={this.state.gender}
            onChange={this.genderChange}></input>
          <input type="radio"
            className="form-control"
            id="female"
            name="gender"
            value="false"
            checked={!this.state.gender}
            onChange={this.genderChange}></input>
        </div>
        <div className="form-group center">
          <button type="submit" className="btn btn-success" disabled={isLoading}>
            Save
            <span className="glyphicon glyphicon-send" />
          </button>
        </div>
      </form>
    );
    return (
      this.state.done ? <redirect to="/" /> : form
    )
  }
}

// UserProfileForm.propTypes = {
//   setProfile: PropTypes.func.isRequired
// }

//export default connect(null, { setProfile })(UserProfileForm);
export default UserProfileForm;