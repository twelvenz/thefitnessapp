import React from 'react';
import './HeroSection.css';
import fitnessImage from '../assets/fitness2.png';

const HeroSection = () => {
    return (
        <div className='hero-section'>
            <p className='welcome-text'>Welcome To THE Fitness App! ...</p>
            <button className="start-button">Start Workout!</button>
            <p className="motivational-message">"Consistency is key – keep going!" - TheFitnessApp Devs</p>
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