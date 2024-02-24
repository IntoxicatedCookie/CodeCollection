module.exports = {
  content: [
    "./pages/**/*.{js,ts,jsx,tsx}",
    "./components/**/*.{js,ts,jsx,tsx}",
  ],
  theme: {
    colors: {
      'royal-red': '#cd192c',
      'pale': '#fff'
    },
    extend: {
      animation: {
        'fade-in': 'fadeIn 3s ease-in-out',
      },

      keyframes: {
        'fade-in': {
          '0%': { background: 'transparent' },
          '100%': { display: 'block' },
        }
      }
    },
  },
  mode: 'jit',
  plugins: [
    require('@tailwindcss/forms'),
  ],
}
