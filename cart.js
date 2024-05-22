document.addEventListener("DOMContentLoaded", function() {
    // Initialize an empty array to store cart items
    var cartItems = [];

    // Function to update the cart HTML
    function updateCartHTML() {
        var cartItemsContainer = document.querySelector(".cart-items");
        cartItemsContainer.innerHTML = ""; // Clear the existing cart items

        // Iterate through cartItems and append each item to the cart HTML
        cartItems.forEach(function(item) {
            var itemElement = document.createElement("div");
            itemElement.classList.add("cart-item");
            itemElement.innerHTML = `
                <span class="item-name">${item.name}</span>
                <span class="item-quantity">${item.quantity}</span>
                <span class="item-price">$${(item.price * item.quantity).toFixed(2)}</span>
            `;
            cartItemsContainer.appendChild(itemElement);
        });

        // Update the total
        updateTotal();
    }

    // Get all "Add to Cart" buttons
    var addToCartButtons = document.querySelectorAll(".add-to-cart");

    // Loop through each button and add a click event listener
    addToCartButtons.forEach(function(button, index) {
        button.addEventListener("click", function() {
            // Get the product details from the corresponding row
            var productRow = button.closest("tr.product-card");
            var productName = productRow.querySelector("td:first-child").innerText;
            var productPrice = parseFloat(productRow.querySelector("td:nth-child(3)").innerText.replace("$", ""));
            var quantity = parseInt(productRow.querySelector("select").value);

            // Create an object representing the added item
            var newItem = {
                name: productName,
                price: productPrice,
                quantity: quantity
            };

            // Add the item to the cart
            cartItems.push(newItem);

            // Log cart items to the console
            console.log(cartItems);

            // Update the cart HTML
            updateCartHTML();

            // Show a confirmation message
            alert("Item added to cart!");
        });
    });

    // Function to update the total
    function updateTotal() {
        var total = cartItems.reduce(function(acc, item) {
            return acc + (item.price * item.quantity);
        }, 0);
        var totalElement = document.querySelector(".total");
        totalElement.innerText = "Total: $" + total.toFixed(2);
    }

    // Initialize the cart HTML
    updateCartHTML();
});
