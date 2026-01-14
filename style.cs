:root {
    --bg-color: #050505;
    --accent-color: #6366f1;
    --text-color: #e2e8f0;
    --glass-bg: rgba(255, 255, 255, 0.03);
    --glass-border: rgba(255, 255, 255, 0.1);
    --transition: all 0.6s cubic-bezier(0.16, 1, 0.3, 1);
}

* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    cursor: none; /* Custom cursor used instead */
}

body {
    background-color: var(--bg-color);
    color: var(--text-color);
    font-family: 'Inter', sans-serif;
    line-height: 1.6;
    overflow-x: hidden;
}

h1, h2, .logo {
    font-family: 'Syne', sans-serif;
    text-transform: uppercase;
}

/* Glassmorphism utility */
.glass {
    background: var(--glass-bg);
    backdrop-filter: blur(12px);
    border: 1px solid var(--glass-border);
    border-radius: 20px;
    padding: 2rem;
}

/* Preloader */
.preloader {
    position: fixed;
    inset: 0;
    background: #000;
    z-index: 9999;
    display: flex;
    justify-content: center;
    align-items: center;
}

.loader-text { font-size: 1rem; letter-spacing: 5px; margin-bottom: 10px; }
.loader-bar { width: 200px; height: 2px; background: #222; position: relative; }
.loader-bar span { position: absolute; height: 100%; background: var(--accent-color); width: 0; transition: 0.5s; }

/* Custom Cursor */
.cursor {
    width: 8px; height: 8px; background: #fff; border-radius: 50%;
    position: fixed; pointer-events: none; z-index: 10000;
}
.cursor-follower {
    width: 40px; height: 40px; border: 1px solid var(--accent-color); border-radius: 50%;
    position: fixed; pointer-events: none; z-index: 9999; transition: transform 0.15s ease-out;
}

/* Hero Section */
.hero {
    height: 100vh;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    background: radial-gradient(circle at 50% 50%, #111 0%, #050505 100%);
}

.glitch-name {
    font-size: 5rem;
    background: linear-gradient(to right, #fff, var(--accent-color));
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    margin: 1rem 0;
}

/* Navigation */
nav {
    position: fixed; width: 100%; top: 0; z-index: 100;
    padding: 1.5rem 0; transition: var(--transition);
}
.nav-container {
    max-width: 1200px; margin: 0 auto; display: flex;
    justify-content: space-between; align-items: center; padding: 0 2rem;
}
.logo { font-size: 1.5rem; text-decoration: none; color: #fff; font-weight: 800; }
.logo span { color: var(--accent-color); }
.nav-links a { text-decoration: none; color: #fff; margin-left: 2rem; font-size: 0.9rem; }

/* Scroll Animation */
.reveal {
    opacity: 0;
    transform: translateY(50px);
    transition: var(--transition);
}
.reveal.active {
    opacity: 1;
    transform: translateY(0);
}

/* Skill Bars */
.progress-bar {
    width: 100%; height: 6px; background: #222; border-radius: 10px; margin-top: 10px;
    overflow: hidden;
}
.progress-bar span {
    display: block; height: 100%; background: var(--accent-color);
    transform: translateX(-100%); transition: 1.5s cubic-bezier(0.16, 1, 0.3, 1);
}
.reveal.active .progress-bar span { transform: translateX(0); }

/* Responsive */
@media (max-width: 768px) {
    .glitch-name { font-size: 2.5rem; }
    .nav-links { display: none; }
}