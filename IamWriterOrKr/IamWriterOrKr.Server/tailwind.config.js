/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./**/*.{razor,html}",
    './Components/Pages/*.{razor,html}',
    './Components/**/*.{razor,html}',
    './Components/*.{razor,html}',
    '../IamWriterOrKr.Server/**/*.{cs,razor}',
    "./node_modules/flowbite/**/*.js"
  ],
  theme: {
    extend: {},
  },
  plugins: [
    require('flowbite/plugin')
  ],
}

