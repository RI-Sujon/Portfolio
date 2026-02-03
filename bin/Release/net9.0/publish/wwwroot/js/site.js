window.scrollToSection = (id) => {
    const el = document.getElementById(id);
    if (el) el.scrollIntoView({ behavior: 'smooth', block: 'start' });
};

// Create floating particles
window.createParticles = () => {
    const container = document.querySelector('.particles');
    if (!container) return;
    
    for (let i = 0; i < 30; i++) {
        const particle = document.createElement('div');
        particle.className = 'particle';
        particle.style.left = Math.random() * 100 + '%';
        particle.style.animationDelay = Math.random() * 10 + 's';
        particle.style.animationDuration = (Math.random() * 10 + 10) + 's';
        particle.style.width = particle.style.height = (Math.random() * 4 + 2) + 'px';
        particle.style.background = ['#64ffda', '#7c3aed', '#ff77c6'][Math.floor(Math.random() * 3)];
        container.appendChild(particle);
    }
};

// Intersection Observer for scroll animations
window.initScrollAnimations = () => {
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('visible');
            }
        });
    }, { threshold: 0.1 });

    document.querySelectorAll('.section').forEach(section => {
        observer.observe(section);
    });
};

// Typing effect
window.initTypingEffect = () => {
    const element = document.querySelector('.typing-wrapper');
    if (!element) return;
    
    const texts = ['Full-Stack Developer', 'Software Engineer', 'Problem Solver', 'Tech Enthusiast'];
    let textIndex = 0;
    let charIndex = 0;
    let isDeleting = false;
    const typingElement = document.querySelector('.typing-dynamic');
    
    function type() {
        if (!typingElement) return;
        
        const currentText = texts[textIndex];
        
        if (isDeleting) {
            typingElement.textContent = currentText.substring(0, charIndex - 1);
            charIndex--;
        } else {
            typingElement.textContent = currentText.substring(0, charIndex + 1);
            charIndex++;
        }
        
        let typeSpeed = isDeleting ? 50 : 100;
        
        if (!isDeleting && charIndex === currentText.length) {
            typeSpeed = 2000;
            isDeleting = true;
        } else if (isDeleting && charIndex === 0) {
            isDeleting = false;
            textIndex = (textIndex + 1) % texts.length;
            typeSpeed = 500;
        }
        
        setTimeout(type, typeSpeed);
    }
    
    type();
};

// Initialize on page load
document.addEventListener('DOMContentLoaded', () => {
    window.createParticles();
    window.initScrollAnimations();
    window.initTypingEffect();
});

// Scroll indicator observer - hides when contact section is visible
window.initScrollIndicatorObserver = (dotNetRef) => {
    const contactSection = document.getElementById('contact');
    if (!contactSection) return;

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            dotNetRef.invokeMethodAsync('OnContactSectionVisible', entry.isIntersecting);
        });
    }, { threshold: 0.3 });

    observer.observe(contactSection);
};

// Get the next section index based on current scroll position
window.getNextSectionIndex = (sectionIds) => {
    const scrollTop = window.scrollY || window.pageYOffset;
    const windowHeight = window.innerHeight;
    
    for (let i = 0; i < sectionIds.length; i++) {
        const section = document.getElementById(sectionIds[i]);
        if (section) {
            const rect = section.getBoundingClientRect();
            // If this section's top is below 20% of viewport, scroll to it
            if (rect.top > windowHeight * 0.2) {
                return i;
            }
        }
    }
    // If we're at the last section, stay there
    return sectionIds.length - 1;
};

// Direct scroll to next section
window.scrollToNextSection = (sectionIds) => {
    const scrollTop = window.scrollY || window.pageYOffset;
    const windowHeight = window.innerHeight;
    
    for (let i = 0; i < sectionIds.length; i++) {
        const section = document.getElementById(sectionIds[i]);
        if (section) {
            const rect = section.getBoundingClientRect();
            // Find first section whose top is more than 100px below viewport top
            if (rect.top > 100) {
                section.scrollIntoView({ behavior: 'smooth', block: 'start' });
                return i;
            }
        }
    }
    return -1;
};