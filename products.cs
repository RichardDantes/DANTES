body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: rgba(245, 245, 245, 0.5); /* Change the overall background color to a milky white */
}

header {
    background-color: #333;
    color: #fff;
    padding: 20px;
    text-align: center;
    font-style: italic;
}

nav {
    background-color: #444;
    padding: 10px 0;
    text-align: center;
}

nav a {
    color: #fff;
    text-decoration: none;
    padding: 10px 20px;
    margin: 0 5px;
}

nav a:hover {
    background-color: #555;
    border-radius: 5px;
    animation: navLinkHover 0.5s forwards;
    transform: scale(1.1);
}

@keyframes navLinkHover {
    0% {
        background-color: #444;
    }
    50% {
        background-color: #555;
    }
    100% {
        background-color: #444;
    }
}

.logo img {
    max-width: 150px;
    height: auto;
    border-radius: 50%;
    border: 5px solid #fff;
}

.description {
    text-align: center;
    font-style: italic;
}

.search-form {
    text-align: center;
}

.content {
    display: flex;
}

.sidebar {
    width: 20%;
    padding: 20px;
}

.sidebar h2 {
    font-family: 'Times New Roman', Times, serif;
}

.sidebar ul {
    list-style-type: none;
    padding: 0;
}

.sidebar ul li {
    margin: 5px 0;
}

.sidebar ul li a {
    text-decoration: none;
    color: #333;
}

.sidebar ul li a:hover {
    text-decoration: underline;
}

.products {
    width: 75%;
    padding: 20px;
}

.product-table {
    width: 100%;
    border-collapse: collapse;
    font-family: 'Times New Roman', Times, serif;
}

.product-table th, .product-table td {
    padding: 10px;
    border: 1px solid #ddd;
    text-align: left;
}

.product-table th {
    background-color: #333;
    color: #fff;
}

.product-table tr:nth-child(even) {
    background-color: #f2f2f2;
}

.product-table tr:hover {
    background-color: #ddd;
}

.add-to-cart {
    background-color: #4CAF50;
    color: white;
    padding: 8px 20px;
    border: none;
    cursor: pointer;
    border-radius: 5px;
    text-decoration: none;
}

.add-to-cart:hover {
    background-color: #45a049;
}

footer {
    text-align: center;
    padding: 20px;
    background-color: #333;
    color: #fff;
    clear: both;
}

/* Pop-up message styling */
.popup-message {
    display: none;
    position: fixed;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    color: #fff;
    font-size: 3em;
    font-family: 'Cursive', sans-serif;
    text-align: center;
    z-index: 1000;
}

.overlay {
    display: none;
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: rgba(0, 0, 0, 0.5);
    z-index: 999;
}
