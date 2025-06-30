fetch("mock-data.json")
  .then(response => response.json())
  .then(data => {
    // Update KPI cards
    document.querySelector(".kpi-card:nth-child(1) p").textContent = data.uptime;
    document.querySelector(".kpi-card:nth-child(2) p").textContent = data.ticketsToday;

    // Chart using tickets data (you can adjust values or make dynamic)
    const ctx = document.getElementById('ticketChart').getContext('2d');
    new Chart(ctx, {
      type: 'bar',
      data: {
        labels: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri'],
        datasets: [{
          label: 'Tickets Opened',
          data: [5, 7, 2, 4, data.ticketsToday],
          backgroundColor: 'rgba(54, 162, 235, 0.7)',
        }]
      },
      options: {
        responsive: true,
        plugins: {
          title: {
            display: true,
            text: 'Weekly Ticket Volume'
          }
        }
      }
    });

    // Optional: Display alerts
    data.alerts.forEach(alert => {
      const alertDiv = document.createElement('div');
      alertDiv.textContent = `${alert.type} - ${alert.status}`;
      alertDiv.style.padding = "8px";
      alertDiv.style.backgroundColor = alert.status === "Active" ? "#f8d7da" : "#d4edda";
      alertDiv.style.marginTop = "5px";
      document.body.appendChild(alertDiv);
    });
  })
  .catch(error => console.error("Error loading mock data:", error));
