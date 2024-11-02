import React from 'react';
import './InfoCSS.css';
import teacherImage from '../assets/teacherbull2.png';

const Learn = () => {
  return (
    <div className="learn-info-container">
      <div className="learn-info-content">
      <img src={teacherImage} alt="Welcome" className="info-image" />
        <div className="learn-text-container">
          <h2 className="learn-info-header">Learn to be Fit!</h2>
          <p className="learn-info-paragraph">
            Learning with TheFitnessApp is fun! You can earn points and level up through completing fitness lessons!
            Lessons are bite-sized, only taking 15 minutes of your time, allowing you to stay fit without a lot of time commitment.
          </p>
        </div>
      </div>
    </div>
  );
};

export default Learn;