import React from 'react'
import { Navbar, Nav, NavDropdown, Container } from 'react-bootstrap'
import { Link } from 'react-router-dom'

export const NavbarMenu = () => {
    return (
        <div>
            <Navbar bg="light" expand="lg">
            <Container>
                <Navbar.Toggle aria-controls="basic-navbar-nav" />
                <Navbar.Collapse id="basic-navbar-nav">
                <Nav className="me-auto">
                    <Nav.Link href="#home">Home</Nav.Link>
                    <Nav.Link href="#link">User Profile</Nav.Link>
                    <NavDropdown title="Master" id="basic-nav-dropdown">
                        <NavDropdown.Item>
                            <Link to="/skillmaster">Skill</Link>
                        </NavDropdown.Item>
                        <NavDropdown.Item>
                            <Link to="/skilllevelmaster">Skill Level</Link>
                        </NavDropdown.Item>
                    </NavDropdown>
                </Nav>
                </Navbar.Collapse>
            </Container>
            </Navbar>
        </div>
    )
}
