function toggleSection(element) {
    const sectionContent = element.nextElementSibling;
    
    sectionContent.style.display = sectionContent.style.display === 'none' ? 'block' : 'none';
    sectionContent.icon.classList.toggle('arrow');
}

// Initialize all sections to be closed
document.querySelectorAll('.section-content').forEach(section => section.style.display = 'none');