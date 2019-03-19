import React from 'react';
import {Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import LoginPage from './components/auth/login/LoginPage';
import RoomsInfo from './components/roomsInfo/RoomsInfo';
import ChambermaidPage from './components/chambermaid/ChambermaidPage'
import ChambermaidForm from './components/chambermaid/ChambermaidForm'
import SignUpPage from './components/auth/signUp/SignUpPage';
import ReserveForm from './components/roomsInfo/ReserveForm';
import 'bootstrap/dist/css/bootstrap.min.css';
export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetchdata/:startDateIndex?' component={FetchData} />
        <Route path='/login' component={LoginPage} />
        <Route path='/chambermaid' component={ChambermaidPage} />
        <Route path='/chambermaidform' component={ChambermaidForm} />
        <Route path='/roomsInfo' component={RoomsInfo} />
        <Route path='/SignUp' component={SignUpPage} />
        <Route path='/ReserveForm/:id' component={ReserveForm} />
    </Layout>
);

