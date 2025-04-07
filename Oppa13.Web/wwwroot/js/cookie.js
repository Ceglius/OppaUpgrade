// Define the hideBanner function to hide the cookie consent banner
function hideBanner() {
    document.getElementById('cookie-consent-banner').style.display = 'none';
}

// Define the setConsent function to update consent preferences
function setConsent(consent) {
    const consentMode = {
        'functionality_storage': consent.necessary ? 'granted' : 'denied',
        'security_storage': consent.necessary ? 'granted' : 'denied',
        'ad_storage': consent.marketing ? 'granted' : 'denied',
        'analytics_storage': consent.analytics ? 'granted' : 'denied',
        'personalization': consent.preferences ? 'granted' : 'denied',
        'ad_personalization': consent.preferences ? 'granted' : 'denied',
        'ad_user_data': consent.preferences ? 'granted' : 'denied',
    };
    // Update consent settings with Google Analytics and save to localStorage
    gtag('consent', 'update', consentMode);
    localStorage.setItem('consentMode', JSON.stringify(consentMode));
}

// Check if the user's consent preferences are already saved
if (localStorage.getItem('consentMode') === null) {
    // If not, display the cookie consent banner
    document.getElementById('cookie-consent-banner').style.display = 'flex';

    // Add event listeners to "Accept All" and "Reject All" buttons
    document.getElementById('btn-accept-all').addEventListener('click', function () {
        setConsent({
            necessary: true,
            analytics: true,
            preferences: true,
            marketing: true
        });
        hideBanner();
    });

    document.getElementById('btn-reject-all').addEventListener('click', function () {
        setConsent({
            necessary: false,
            analytics: false,
            preferences: false,
            marketing: false
        });
        hideBanner();
    });
}
