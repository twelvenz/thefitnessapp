import React from 'react';
import './Leaderboard.css';


const board = () => {
    // Sample data for the leaderboard
    const global_ranks = [
      { rank: 1, name: 'Alice', score: 100 },
      { rank: 2, name: 'Bob', score: 33 },
      { rank: 3, name: 'Charlie', score: 14 },
      { rank: 4, name: 'David', score: 7 },
      { rank: 5, name: 'Eve', score: 1 },
    ];
    const local_ranks = [
      { rank: 1, name: 'Alice', score: 100 },
      { rank: 2, name: 'Bob', score: 33 },
      { rank: 3, name: 'Charlie', score: 14 },
      { rank: 4, name: 'David', score: 7 },
      { rank: 5, name: 'Eve', score: 1 },
    ];
    const friend_ranks = [
      { rank: 1, name: 'Friend 1', score: 5 },
      { rank: 2, name: 'Friend 2', score: 3 },
      { rank: 3, name: 'Friend 3', score: 0 },
    ];
  
    return (
      <div className="leaderboard-container">
        <h1>Global Streaks</h1>
        <table className="leaderboard-table">
          <thead>
            <tr>
              <th>Rank</th>
              <th>Name</th>
              <th>Streak</th>
            </tr>
          </thead>
          <tbody>
            {global_ranks.map((user) => (
              <tr key={user.rank}>
                <td>{user.rank}</td>
                <td>{user.name}</td>
                <td>{user.score}</td>
              </tr>
            ))}
          </tbody>
        </table>

        <h1>Local Streaks</h1>
        <table className="leaderboard-table">
          <thead>
            <tr>
              <th>Rank</th>
              <th>Name</th>
              <th>Streak</th>
            </tr>
          </thead>
          <tbody>
            {local_ranks.map((user) => (
              <tr key={user.rank}>
                <td>{user.rank}</td>
                <td>{user.name}</td>
                <td>{user.score}</td>
              </tr>
            ))}
          </tbody>
        </table>

        <h1>Friends Streaks</h1>
        <table className="leaderboard-table">
          <thead>
            <tr>
              <th>Rank</th>
              <th>Name</th>
              <th>Streak</th>
            </tr>
          </thead>
          <tbody>
            {friend_ranks.map((user) => (
              <tr key={user.rank}>
                <td>{user.rank}</td>
                <td>{user.name}</td>
                <td>{user.score}</td>
              </tr>
            ))}
          </tbody>
        </table>

      </div>
      
    );
  };
  
export default board;