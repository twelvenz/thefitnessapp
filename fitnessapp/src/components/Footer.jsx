// src/components/Footer.jsx
import React from 'react';
import './Footer.css'; // Create a separate CSS file for styling

const Footer = () => {
    return (
        <footer className="footer">
            <div className="footer-links">
                <a href="/about">About Us</a>
                <a href="/contact">Contact</a>
                <a href="/privacy">Privacy Policy</a>
                <a href="/terms">Terms of Service</a>
            </div>
            <div className="social-media">
                <a href="https://facebook.com" target="_blank" rel="noopener noreferrer">
                    <i className="fab fa-facebook"></i>
                </a>
                <a href="https://twitter.com" target="_blank" rel="noopener noreferrer">
                    <i className="fab fa-twitter"></i>
                </a>
                <a href="https://instagram.com" target="_blank" rel="noopener noreferrer">
                    <i className="fab fa-instagram"></i>
                </a>
            </div>
            <p className="copyright">© 2024 TheFitnessApp. All rights reserved.</p>
        </footer>
    );
}

export default Footer;
