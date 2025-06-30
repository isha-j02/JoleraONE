const ctx = document.getElementById('overviewChart').getContext('2d');
new Chart(ctx, {
  type: 'bar',
  data: {
    labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun'],
    datasets: [{
      label: 'Open Tickets',
      data: [5, 7, 6, 9, 4, 3, 5],
      backgroundColor: '#2e6af3'
    }]
  },
  options: {
    responsive: true,
    plugins: {
      legend: { display: true },
      title: { display: true, text: 'Open Tickets – Last 7 Days' }
    }
  }
});
