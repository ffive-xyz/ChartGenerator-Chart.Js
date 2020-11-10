var ctx = document.getElementById("myChart").getContext("2d");
var doughnut = {
  type: "bar",
  options: {
    responsive: true,
    responsiveAnimationDuration: 0.0,
    aspectRatio: 1.4,
    maintainAspectRatio: true,
    title: {
      display: true,
      position: 2,
      fontSize: 50.0,
      fontColor: "#666",
      fontStyle: "bold",
      padding: 20.0,
      lineHeight: 1.2,
      text: "Yesterday Cost Analysis",
    },
    animation: { Duration: 0.0 },
    layout: { Padding: { Left: 0.0, Right: 0.0, Top: 0.0, Bottom: 0.0 } },
    legend: {
      display: true,
      position: "bottom",
      align: "center",
      fullWidth: true,
      reverse: false,
      labels: {
        boxWidth: 80.0,
        fontSize: 25.0,
        fontStyle: "bold",
        fontColor: "#666",
        padding: 50.0,
      },
    },
    scales: null,
  },
  data: {
    labels: [
      ["Compute", "Cloud", "Compute"],
      ["Load", "Balancing"],
      ["Relational", "Database", "Service"],
    ],
    datasets: [
      {
        label: "",
        data: [61.13, 0.0, 0.0],
        backgroundColor: [
          "rgba(255, 99, 132, 0.8)",
          "rgba(255, 206, 86, 0.8)",
          "rgba(54, 162, 235, 0.8)",
          "rgba(75, 192, 192, 0.8)",
          "rgba(153, 102, 255, 0.8)",
          "rgba(255, 159, 64, 0.8)",
        ],
        borderColor: [
          "rgba(255, 99, 132, 0.8)",
          "rgba(255, 206, 86, 0.8)",
          "rgba(54, 162, 235, 0.8)",
          "rgba(75, 192, 192, 0.8)",
          "rgba(153, 102, 255, 0.8)",
          "rgba(255, 159, 64, 0.8)",
        ],
        borderWidth: 1.0,
      },
    ],
  },
};

var chart = new Chart(ctx, doughnut);
