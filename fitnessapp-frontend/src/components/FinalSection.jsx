import React from 'react';
import './InfoCSS.css';
import buffcow from '../assets/teacherbull.png';
const FinalSection = () => {
  return (
    <div className="learn-info-container">
      <div className="learn-info-content">
      <img src={buffcow} alt="Welcome" className="info-image" />
        <div className="learn-text-container">
          <h2 className="learn-info-header">Exercise Everywhere, Everytime!</h2>
          <p className="learn-info-paragraph">
          </p>
        </div>
      </div>
    </div>
  );
};

export default FinalSection;