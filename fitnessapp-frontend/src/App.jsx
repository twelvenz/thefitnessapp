import React from 'react';
import { BrowserRouter as Router, Routes, Route} from 'react-router-dom';
import Navbar from './components/Navbar';
import HomeContent from './components/HomeContent';
import Leaderboard from './components/Leaderboard';
import Activity from './components/Activity';

function App() {
  return (
    <Router>
      <Navbar />
      <Routes>
      <Route path="/" element={<HomeContent />} />
        <Route path="/activity" element={<Activity />} />
        <Route path="/leaderboard" element={<Leaderboard />} />
      </Routes>
    </Router>
  );
}

export default App;
