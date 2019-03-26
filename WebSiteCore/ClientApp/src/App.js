import React from 'react';
import {Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import LoginPage from './components/auth/login/LoginPage';
import Room from './components/roomBooking/Room';
import StandartsPage from './components/roomBooking/StandartsPage';
import SignUpPage from './components/auth/signUp/SignUpPage';
import Contacts from './components/contacts/Contacts';
import 'bootstrap/dist/css/bootstrap.min.css';
import UserProfilePage from './components/UserProfilePage';
import Offers from './components/offers/Offers';

export default () => (
    <Layout>
        <Route exact path='/' component={StandartsPage} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
        <Route path='/login' component={LoginPage} />
        <Route path='/room' component={Room} />
        <Route path='/SignUp' component={SignUpPage} />
        <Route path='/profile' component={UserProfilePage} />
        <Route path='/contacts' component={Contacts} />
        <Route path='/offers' component={Offers} />
    </Layout>
);

//        <Route path='/profile' component={UserProfilePage} />
