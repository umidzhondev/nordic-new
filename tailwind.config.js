/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './**/*.razor',
    './**/*.html',
    './wwwroot/index.html'
  ],
  theme: {
    extend: {
      colors: {
        nordic: {
          bg: '#f7f4ee',
          card: '#eae4d8',
          cardHover: '#f2efe9',
          text: '#2c2a29',
          muted: '#8c8275',
          border: '#e5dfd3',
          terracotta: '#bd5d38',
          forest: '#3e5c43'
        }
      }
    },
  },
  plugins: [],
}