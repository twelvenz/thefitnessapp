import React, { useEffect, useState } from 'react';
import './Exercises.css'; // Import your CSS file if you plan to use it

const Exercises = () => {
  const [exercises, setExercises] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchExercises = async () => {
      try {
        const response = await fetch('http://localhost:5001/exercises'); // Adjust this URL if needed
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        const data = await response.json();
        setExercises(data);
      } catch (error) {
        console.error('Error fetching exercises:', error);
      } finally {
        setLoading(false);
      }
    };

    fetchExercises();
  }, []);

  if (loading) {
    return <div>Loading...</div>;
  }

  return (
    <div className="exercise-container">
      {exercises.map((exercise) => (
        <div className="exercise-card" key={exercise.id}>
          <h3>{exercise.name}</h3>
          <p><strong>Category:</strong> {exercise.category}</p>
          <p><strong>Level:</strong> {exercise.level}</p>
          <p><strong>Primary Muscles:</strong> {exercise.primaryMuscles.join(', ')}</p>
          <img src={exercise.images[0]} alt={exercise.name} /> {/* Display the first image */}
          <p><strong>Instructions:</strong></p>
          <ul>
            {exercise.instructions.map((instruction, index) => (
              <li key={index}>{instruction}</li>
            ))}
          </ul>
        </div>
      ))}
    </div>
  );
};

export default Exercises;
