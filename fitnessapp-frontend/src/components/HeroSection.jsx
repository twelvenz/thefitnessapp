import React from 'react';
import { Link } from 'react-router-dom';
import './HeroSection.css';
import fitnessImage from '../assets/fitness2.png';

const HeroSection = () => {
    return (
        <div className='hero-section'>
            <p className='welcome-text'>Welcome To THE Fitness App!</p>
            <Link to="/activity">
                <button className="start-button">Start Workout!</button>
            </Link>
            <p className="motivational-message">"Consistency is key – keep going!"</p>
            <div 
                className="illustration"
                style ={{
                    backgroundImage: `url(${fitnessImage})`,
                    backgroundSize: 'cover',
                    backgroundPosition: 'center',
                    width: '100%',
                    height: '500px'

                }}
            >
            </div>
        </div>
    )
}

export default HeroSection;