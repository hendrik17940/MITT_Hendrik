import React, { Component } from 'react'
import { Card, Button, Table } from 'react-bootstrap'
import axios from 'axios';

export class SkillLevel extends Component {

    state = {
        items: []
    }
    
    componentDidMount() {
        axios
        .get(`http://localhost:49440/Api/GetSkill`)
        .then(response => {
            const items = response.data;
            console.log(items);
            this.setState({items});
        })
    }

    render() {
        return (
            <div>
                <div className="container mt-4">
                    <Card>
                        <Card.Header>Master Skill</Card.Header>
                        <Card.Body>
                            <Button variant="success">Add Data</Button>
                            <Table className="mt-4" striped bordered hover>
                                <thead>
                                    <tr>
                                    <th>Skill Level Id</th>
                                    <th>Skill Level Name</th>
                                    </tr>
                                </thead>
                                <tbody>
                                        { this.state.items.map(item => 
                                            <tr key={item.skillId}>
                                                <td>{item.skillId}</td>
                                                <td>{item.skillName}</td>
                                                <td>
                                                    <Button variant="info">Edit</Button>
                                                    <Button variant="danger">Delete</Button>
                                                </td>
                                            </tr>
                                        )}
                                </tbody>
                            </Table>
                        </Card.Body>
                    </Card>
                    
                </div>
            </div>
        )
    }
}

export default SkillLevel

