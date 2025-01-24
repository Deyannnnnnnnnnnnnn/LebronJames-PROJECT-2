// Добавяне на коментари
document.getElementById("commentForm").addEventListener("submit", function (e) {
    e.preventDefault();
    const commentText = document.getElementById("commentText").value;
    const commentsSection = document.getElementById("commentsSection");

    const newComment = document.createElement("p");
    newComment.textContent = commentText;
    commentsSection.appendChild(newComment);

    document.getElementById("commentText").value = ""; // Изчистване на полето
});
