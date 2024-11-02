import React from 'react';
import './Navbar.css';

const Navbar = () => {
  return (

<nav className="navbar">
  <div className="navbar-left">
    <a href="/" className="logo">
      TheFitnessApp
    </a>
  </div>
  <div className="navbar-center">
    <ul className="nav-links">
      <li>
        <a href="/home">Home</a>
      </li>
      <li>
        <a href="/activity">Activity</a>
      </li>
      <li>
        <a href="/contact">Leaderboard</a>
      </li>
    </ul>
  </div>
  <div className="navbar-right">
    <a href="/cart" className="notif-icon">
      <i className="fas fa-bell"></i>
      <span className="notif-count">0</span>
    </a>
    <a href="/account" className="user-icon">
      <i className="fas fa-user"></i>
    </a>
  </div>
</nav>
);
};

export default Navbar;