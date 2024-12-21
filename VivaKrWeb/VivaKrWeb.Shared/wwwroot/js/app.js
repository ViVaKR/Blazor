const initBootstrapPlugins = () => {
    // Tooltips
    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]');
    [...tooltipTriggerList].forEach(tooltipTriggerEl => {
        const tooltip = new bootstrap.Tooltip(tooltipTriggerEl, {
            trigger: 'hover',
            html: true
        });

        tooltipTriggerEl.addEventListener('mouseleave', () => {
            tooltip.hide();
        });
    });

    // Popovers
    const popoverTriggerList = document.querySelectorAll('[data-bs-toggle="popover"]');
    [...popoverTriggerList].forEach(popoverTriggerEl => {
        const popover = new bootstrap.Popover(popoverTriggerEl);

        document.addEventListener('click', (e) => {
            if (!popoverTriggerEl.contains(e.target)) {
                popover.hide();
            }
        });
    });
};

const observeBootstrapElements = () => {
    initBootstrapPlugins();

    const observer = new MutationObserver(() => {
        initBootstrapPlugins();
    });

    observer.observe(document.body, {
        childList: true,
        subtree: true
    });
};

window.observeBootstrapElements = observeBootstrapElements;
