import React from 'react';
import './InfoCSS.css';
import robotBull from '../assets/robotbull.png';

const AISection = () => {
    return (
        <div className="learn-info-container">
          <div className="learn-info-content">
            <div className="learn-text-container">
              <h2 className="learn-info-header">Get Fit with Pals!</h2>
              <p className="learn-info-paragraph">
                Work out with friends and track progress through leaderboards!
              </p>
              <p>-</p>
              <p> </p>
              <p className="learn-info-paragraph">
                No friends? No worries! There's Buffy the bull!
              </p>
              <p> </p>
              <p className="learn-info-paragraph">
                Our friendly AI bull bot can give you advice and motivation throughout your workout.
              </p>
            </div>
            <img src={robotBull} alt="Welcome" className="info-image" />
          </div>
        </div>
      );
    };    

export default AISection;