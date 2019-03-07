import React, { Component } from 'react';
import { Col, Row } from 'react-bootstrap';

class ChambermaidPage extends Component {
    render() {
        return (
            <div>
                <table className='table'>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Full Name</th>
                            <th>To clean the rooms</th>
                            <th>Ready rooms</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>0</td>
                            <td>Chambermaid num 1</td>
                            <td>34,45,11</td>
                            <td>13,10,22</td>
                        </tr>
                        <tr>
                            <td>1</td>
                            <td>Chambermaid num 2</td>
                            <td>14,19,15</td>
                            <td>53,2,12</td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Chambermaid num 3</td>
                            <td>35,25,31</td>
                            <td>16,9,2</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        );
    }
}
export default ChambermaidPage;