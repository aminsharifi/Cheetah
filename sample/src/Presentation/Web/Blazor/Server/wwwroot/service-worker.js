// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.addEventListener('fetch', () => { });
//self.addEventListener('install', (event) => {
//    console.log('Service Worker installing.');
//});

//self.addEventListener('activate', (event) => {
//    console.log('Service Worker activating.');
//});

//self.addEventListener('fetch', (event) => {
//    console.log('Fetching:', event.request.url);
//});