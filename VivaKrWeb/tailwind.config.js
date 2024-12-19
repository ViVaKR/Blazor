/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./VivaKrWeb.Shared/**/*.{razor,html}",
    "./VivaKrWeb.Web/**/*.{razor,html}",
    "./VivaKrWeb.Shared/Layout/**/*.{razor,html}"
  ],
  theme: {
    extend: {
      fontFamily: {
        poppins: ['Poppins', 'sans-serif'],
        ibm: ['IBM Plex Sans', 'sans-serif'],
        cute: ['Cute Font', 'sans-serif'],
        noto: ['Noto Sans KR', 'sans-serif'],
        firacode: ['Fira Code', 'monospace']
      },
      backgroundImage: {
        'robot': "url('../images/robot-man.webp')"
      },
    },
  },
  plugins: [],
}

