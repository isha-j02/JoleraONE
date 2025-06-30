fetch("mock-data.json")
  .then(res => res.json())
  .then(data => {
    // Update KPI values
    document.querySelector(".kpi-card:nth-child(1) p").textContent = data.uptime;
    document.querySelector(".kpi-card:nth-child(2) p").textContent = data.ticketsToday;

    // Chart setup
    const ctx = document.getElementById("ticketChart").getContext("2d");
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
        maintainAspectRatio: false,
        plugins: {
          title: {
            display: true,
            text: 'Weekly Ticket Volume'
          }
        }
      }
    });

    // Display alerts in a container
    const alertContainer = document.getElementById("alertContainer");
    data.alerts.forEach(alert => {
      const div = document.createElement("div");
      div.textContent = `${alert.type} - ${alert.status}`;
      div.classList.add("alert");
      div.classList.add(alert.status === "Active" ? "alert-red" : "alert-green");
      alertContainer.appendChild(div);
    });
  });
