import React from 'react';
import './Leaderboard.css';


const board = () => {
    // Sample data for the leaderboard
    const global_ranks = [
      { rank: 1, name: 'FitLegend', score: 998 },
      { rank: 2, name: 'Coach T', score: 729 },
      { rank: 3, name: 'Arm_Day', score: 720 },
      { rank: 4, name: 'WorkoutFan', score: 583 },
      { rank: 5, name: 'I_Love_Leg_Day', score: 427 },
    ];
    const local_ranks = [
      { rank: 1, name: 'Local 1', score: 187 },
      { rank: 2, name: 'Local 2', score: 100 },
      { rank: 3, name: 'Local 3', score: 99 },
      { rank: 4, name: 'Local 4', score: 98 },
      { rank: 5, name: 'Local 5', score: 77 },
    ];
    const friend_ranks = [
      { rank: 1, name: 'Friend 1', score: 21 },
      { rank: 2, name: 'Friend 2', score: 10 },
      { rank: 3, name: 'Friend 3', score: 9 },
      { rank: 4, name: 'Friend 4', score: 0 },
    ];

    const getMedal = (rank) => {
      if (rank === 1) return '🥇';
      if (rank === 2) return '🥈';
      if (rank === 3) return '🥉';
      return '';
    };

    const fireEmoji = (score) => {
      if (score > 99) {
        return `${score} 🐂`; 
      } else if (score > 9) {
        return `${score} 🔥`; 
      }
      return score; 
    };
  
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
                <td className="rank">{getMedal(user.rank)} {user.rank}</td>
                <td>{user.name}</td>
                <td>{fireEmoji(user.score)}</td>
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
                <td className="rank">{getMedal(user.rank)} {user.rank}</td>
                <td>{user.name}</td>
                <td>{fireEmoji(user.score)}</td>
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
                <td className="rank">{getMedal(user.rank)} {user.rank}</td>
                <td>{user.name}</td>
                <td>{fireEmoji(user.score)}</td>
              </tr>
            ))}
          </tbody>
        </table>

      </div>
      
    );
  };
  
export default board;