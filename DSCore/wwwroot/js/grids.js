﻿const getCellValue = (tr, idx) => tr.children[idx].innerText || tr.children[idx].textContent;

const comparer = (idx, asc) => (a, b) => ((v1, v2) =>
    v1 !== "" && v2 !== "" && !isNaN(v1) && !isNaN(v2) ? v1 - v2 : v1.toString().localeCompare(v2)
)(getCellValue(asc ? a : b, idx).replace(/\,/g, "").replace(/\$/g, ""), getCellValue(asc ? b : a, idx).replace(/\,/g, "").replace(/\$/g, ""));

// do the work...
document.getElementById("tbl-header").querySelectorAll("td").forEach(td => td.addEventListener("click", (() => {
    const table = td.closest("table");
    const tbody = table.querySelector('tbody');
    Array.from(tbody.querySelectorAll('tr'))
        .sort(comparer(Array.from(td.parentNode.children).indexOf(td), this.asc = !this.asc))
        .forEach(tr => tbody.appendChild(tr));
})));