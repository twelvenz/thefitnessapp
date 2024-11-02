import React, { useEffect, useState } from 'react';
import './Exercises.css';

const Exercises = () => {
  const [exercises, setExercises] = useState([]);
  const [filteredExercises, setFilteredExercises] = useState([]);
  const [searchTerm, setSearchTerm] = useState('');
  const [category, setCategory] = useState(''); 
  const [level, setLevel] = useState('');       

  useEffect(() => {
    const fetchExercises = async () => {
      try {
        const response = await fetch('http://localhost:5001/exercises');
        const data = await response.json();
        setExercises(data);
        setFilteredExercises(data); 
      } catch (error) {
        console.error('Error fetching exercises:', error);
      }
    };

    fetchExercises();
  }, []);

  useEffect(() => {
    const filtered = exercises.filter((exercise) => {
      const matchesSearch = exercise.name.toLowerCase().includes(searchTerm.toLowerCase());
      const matchesCategory = category ? exercise.category.toLowerCase() === category.toLowerCase() : true;
      const matchesLevel = level ? exercise.level.toLowerCase() === level.toLowerCase() : true;

      return matchesSearch && matchesCategory && matchesLevel;
    });
    setFilteredExercises(filtered);
  }, [searchTerm, category, level, exercises]);

  return (
    <div>
        <div className='search-container'>
            <input 
                type="text" 
                placeholder="Search exercises..." 
                value={searchTerm}
                onChange={(e) => setSearchTerm(e.target.value)}
            />
            <select value={category} onChange={(e) => setCategory(e.target.value)}>
                <option value="">All Categories</option>
                <option value="strength">Strength</option>
                <option value="cardio">Cardio</option>
            </select>
            <select value={level} onChange={(e) => setLevel(e.target.value)}>
                <option value="">All Levels</option>
                <option value="beginner">Beginner</option>
                <option value="intermediate">Intermediate</option>
                <option value="expert">Expert</option>
            </select>
        </div>
        <div className="exercise-container">
            {filteredExercises.map((exercise) => (
                <div className="exercise-card" key={exercise.id}>
                    <h3>{exercise.name}</h3>
                    <p><strong>Category:</strong> {exercise.category}</p>
                    <p><strong>Level:</strong> {exercise.level}</p>
                    <p><strong>Primary Muscles:</strong> {exercise.primaryMuscles.join(', ')}</p>
                    <img src={exercise.images[0]} alt={exercise.name} />
                    <p><strong>Instructions:</strong></p>
                    <ul>
                        {exercise.instructions.map((instruction, index) => (
                            <li key={index}>{instruction}</li>
                        ))}
                    </ul>
                </div>
            ))}
        </div>
    </div>
  );
};

export default Exercises;



