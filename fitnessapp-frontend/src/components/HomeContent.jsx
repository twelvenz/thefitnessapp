import React from 'react';
import HeroSection from './HeroSection';
import LearnSection from './LearnSection';
import AISection from './AISection';
import FinalSection from './FinalSection';
import Footer from './Footer';


const HomeContent = () => {
    return (
        <div className='home-content'>
            <HeroSection />
            <LearnSection />
            <AISection />
            <FinalSection/>
            <Footer />
        </div>
    )
}
export default HomeContent;