const paragraphs = document.querySelectorAll(".contentPost");

for (let i = 0; i < paragraphs.length; i++) {
  const words = paragraphs[i].textContent.trim().split(" ");
  if (words.length > 50) {
    const summary = words.slice(0, 50).join(" ") + "...";
    const remaining = words.slice(50).join(" ");
    paragraphs[i].textContent = summary + " ";
    const readMoreLink = document.createElement("a");
      readMoreLink.classList.add("text-decoration-none");
     readMoreLink.style.color="rgb(64 66 145)";
    readMoreLink.href = "Reply and comment on the query.html"; // replace with desired URL
    readMoreLink.textContent = "Read More";
    paragraphs[i].appendChild(readMoreLink);
  }
}