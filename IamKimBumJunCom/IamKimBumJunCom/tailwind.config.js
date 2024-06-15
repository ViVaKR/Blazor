/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.{razor,html,cshtml}",
    "**/*.razor",
    "**/*.html",
    "**/*.cshtml",
    "./node_modules/flowbite/**/*.js",
  ],
  theme: {
    container: {
      center: true,
    },
    extend: {},
  },
  plugins: [
    require('flowbite/plugin')
  ],
  darkMode: 'media'
}

