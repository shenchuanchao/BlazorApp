window.chartHelpers = {
    createChart: function (canvasId, config) {
        const ctx = document.getElementById(canvasId).getContext('2d');
        return new Chart(ctx, config);
    },

    updateChart: function (chart, data) {
        chart.data = data;
        chart.update();
    },

    destroyChart: function (chart) {
        chart.destroy();
    }
};