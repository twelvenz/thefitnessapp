import React from 'react';
import { Link } from 'react-router-dom';
import './Navbar.css';
import logo from '../assets/logo.png';

const Navbar = () => {
  return (

<nav className="navbar">
  <div className="navbar-left">
    <Link to="/" className="logo">
    <img src={logo} alt="The Fitness App Logo" className="logo-image" />
      TheFitnessApp
    </Link>
  </div>
  <div className="navbar-center">
    <ul className="nav-links">
      <li>
        <Link to="/">Home</Link>
      </li>
      <li>
        <Link to="/activity">Activity</Link>
      </li>
      <li>
        <Link to="/leaderboard">Leaderboard</Link>
      </li>
      <li>
        <Link to="/coming-soon">BuffyBot</Link> {/* not yet implemented */}
      </li>
    </ul>
  </div>
  <div className='premium'>
      <Link to="/coming-soon" className='premium-button'>Get Premium</Link> {/* not yet implemented */}
  </div>
  <div className="navbar-right">
    <Link to="/coming-soon" className="notif-icon">
      <i className="fas fa-bell"></i>
      <span className="notif-count">0</span>
    </Link>
    <Link to="/coming-soon" className="user-icon">
      <i className="fas fa-user"></i>
    </Link>
  </div>
</nav>
);
};

export default Navbar;