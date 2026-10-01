@import url('https://fonts.googleapis.com/css2?family=Inter:wght@400;500;600;700;800&display=swap');


* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}


html {
    scroll-behavior: smooth;
}


body {
    font-family: 'Inter', sans-serif;
    background: #0b0f19;
    color: #ffffff;
    line-height: 1.6;
}


/* NAVBAR */

header {
    position: fixed;
    top: 0;
    width: 100%;
    z-index: 1000;
    background: rgba(11, 15, 25, 0.85);
    backdrop-filter: blur(15px);
}


.navbar {
    max-width: 1200px;
    margin: auto;
    height: 75px;

    display: flex;
    align-items: center;
    justify-content: space-between;

    padding: 0 25px;
}


.logo {
    font-size: 25px;
    font-weight: 800;
}


.logo span {
    color: #6c63ff;
}


.nav-menu {
    display: flex;
    list-style: none;
    gap: 35px;
}


.nav-menu a {
    color: #ffffff;
    text-decoration: none;
    font-size: 14px;
    transition: 0.3s;
}


.nav-menu a:hover {
    color: #6c63ff;
}


.menu-toggle {
    display: none;
    font-size: 25px;
    cursor: pointer;
}


/* HERO */

.hero {
    min-height: 100vh;
    max-width: 1200px;
    margin: auto;

    padding: 120px 25px 60px;

    display: flex;
    align-items: center;
    justify-content: space-between;

    gap: 60px;
}


.hero-text {
    max-width: 650px;
}


.hello {
    color: #6c63ff;
    font-weight: 700;
    letter-spacing: 4px;
    font-size: 14px;
    margin-bottom: 15px;
}


.hero h1 {
    font-size: clamp(50px, 7vw, 85px);
    line-height: 1.05;
    letter-spacing: -4px;
}


.hero h1 span {
    color: #6c63ff;
}


.description {
    margin-top: 25px;
    color: #a7adbd;
    max-width: 600px;
    font-size: 16px;
}


.hero-buttons {
    display: flex;
    gap: 15px;
    margin-top: 35px;
}


.btn {
    padding: 13px 25px;
    border-radius: 8px;
    text-decoration: none;
    font-weight: 600;
    transition: 0.3s;
}


.primary {
    background: #6c63ff;
    color: white;
}


.primary:hover {
    transform: translateY(-3px);
}


.secondary {
    border: 1px solid #343a4d;
    color: white;
}


.secondary:hover {
    background: #171c2b;
}


/* PROFILE IMAGE */

.hero-image {
    display: flex;
    justify-content: center;
}


.image-circle {
    width: 330px;
    height: 330px;

    border-radius: 50%;

    padding: 8px;

    background: linear-gradient(
        135deg,
        #6c63ff,
        #9b95ff,
        #272d42
    );
}


.image-circle img {
    width: 100%;
    height: 100%;

    object-fit: cover;

    border-radius: 50%;

    border: 7px solid #0b0f19;
}


/* SECTION */

.section {
    max-width: 1200px;
    margin: auto;
    padding: 110px 25px;
}


.section-title {
    margin-bottom: 55px;
}


.section-title p {
    color: #6c63ff;
    font-weight: 700;
    letter-spacing: 3px;
    font-size: 13px;
}


.section-title h2 {
    font-size: 40px;
    margin-top: 5px;
}


/* ABOUT */

.about-content {
    display: grid;
    grid-template-columns: 1.2fr 1fr;
    gap: 50px;
}


.about-card,
.info-card {
    background: #111725;
    border: 1px solid #20283a;
    border-radius: 15px;
    padding: 35px;
}


.about-card h3 {
    font-size: 25px;
    margin-bottom: 20px;
}


.about-card p {
    color: #a7adbd;
    margin-bottom: 15px;
}


.info-item {
    display: flex;
    justify-content: space-between;
    gap: 20px;
    padding: 18px 0;
    border-bottom: 1px solid #252c3d;
}


.info-item:last-child {
    border-bottom: none;
}


.info-item span {
    color: #858da0;
}


.info-item strong {
    text-align: right;
}


/* SKILLS */

.skills-section {
    max-width: none;
    background: #0e1320;
}


.skills-section .section-title,
.skills-container {
    max-width: 1150px;
    margin-left: auto;
    margin-right: auto;
}


.skills-container {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 20px;
}


.skill-card {
    background: #111725;
    border: 1px solid #20283a;
    border-radius: 15px;
    padding: 30px;

    transition: 0.3s;
}


.skill-card:hover {
    transform: translateY(-7px);
    border-color: #6c63ff;
}


.skill-icon {
    color: #6c63ff;
    font-weight: 800;
    margin-bottom: 25px;
}


.skill-card h3 {
    margin-bottom: 10px;
}


.skill-card p {
    color: #8f97aa;
    font-size: 14px;
}


/* PROJECT */

.project-container {
    display: flex;
    flex-direction: column;
    gap: 20px;
}


.project-card {
    background: #111725;
    border: 1px solid #20283a;
    border-radius: 15px;

    padding: 35px;

    display: grid;
    grid-template-columns: 100px 1fr;

    transition: 0.3s;
}


.project-card:hover {
    transform: translateX(8px);
    border-color: #6c63ff;
}


.project-number {
    color: #6c63ff;
    font-size: 20px;
    font-weight: 800;
}


.project-card h3 {
    font-size: 23px;
    margin-bottom: 10px;
}


.project-card p {
    color: #8f97aa;
    max-width: 700px;
}


.tags {
    display: flex;
    gap: 10px;
    margin-top: 20px;
    flex-wrap: wrap;
}


.tags span {
    background: #1b2131;
    color: #aeb5c5;
    padding: 6px 12px;
    border-radius: 5px;
    font-size: 12px;
}


/* CONTACT */

.contact-section {
    background: #0e1320;
    padding: 110px 25px;
    text-align: center;
}


.contact-text {
    max-width: 600px;
    margin: -20px auto 45px;
    color: #8f97aa;
}


.contact-container {
    max-width: 900px;
    margin: auto;

    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 20px;
}


.contact-card {
    background: #111725;
    border: 1px solid #20283a;

    border-radius: 12px;
    padding: 25px;

    text-decoration: none;
    color: white;

    transition: 0.3s;
}


.contact-card:hover {
    border-color: #6c63ff;
    transform: translateY(-5px);
}


.contact-card span {
    display: block;
    color: #6c63ff;
    font-size: 12px;
    font-weight: 700;
    margin-bottom: 8px;
}


.contact-card strong {
    font-size: 14px;
}


/* FOOTER */

footer {
    text-align: center;
    padding: 30px;
    color: #626b7e;
    font-size: 13px;
    border-top: 1px solid #20283a;
}


/* RESPONSIVE */

@media (max-width: 850px) {

    .nav-menu {
        position: absolute;
        top: 75px;
        right: 0;

        width: 100%;

        background: #0b0f19;

        flex-direction: column;
        align-items: center;

        padding: 30px;

        display: none;
    }


    .nav-menu.active {
        display: flex;
    }


    .menu-toggle {
        display: block;
    }


    .hero {
        flex-direction: column-reverse;
        text-align: center;
        padding-top: 140px;
    }


    .hero-buttons {
        justify-content: center;
    }


    .image-circle {
        width: 250px;
        height: 250px;
    }


    .about-content {
        grid-template-columns: 1fr;
    }


    .skills-container {
        grid-template-columns: repeat(2, 1fr);
    }


    .contact-container {
        grid-template-columns: 1fr;
    }

}


@media (max-width: 500px) {

    .hero h1 {
        font-size: 48px;
    }


    .hero-buttons {
        flex-direction: column;
    }


    .skills-container {
        grid-template-columns: 1fr;
    }


    .project-card {
        grid-template-columns: 1fr;
        gap: 15px;
    }


    .info-item {
        flex-direction: column;
    }


    .info-item strong {
        text-align: left;
    }

}
```css
/* FAMILY */

.family-intro {
    max-width: 700px;
    color: #8f97aa;
    margin-top: -30px;
    margin-bottom: 45px;
}


.family-container {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    gap: 25px;
}


.family-card {
    background: #111725;
    border: 1px solid #20283a;
    border-radius: 15px;
    overflow: hidden;

    transition: 0.3s;
}


.family-card:hover {
    transform: translateY(-8px);
    border-color: #6c63ff;
}


.family-image {
    width: 100%;
    height: 250px;
    overflow: hidden;
}


.family-image img {
    width: 100%;
    height: 100%;
    object-fit: cover;

    transition: 0.4s;
}


.family-card:hover .family-image img {
    transform: scale(1.05);
}


.family-info {
    padding: 25px;
}


.family-info span {
    color: #6c63ff;
    font-size: 12px;
    font-weight: 700;
    letter-spacing: 2px;
}


.family-info h3 {
    font-size: 23px;
    margin: 7px 0 10px;
}


.family-info p {
    color: #8f97aa;
    font-size: 14px;
}


/* FAMILY RESPONSIVE */

@media (max-width: 850px) {

    .family-container {
        grid-template-columns: repeat(2, 1fr);
    }

}


@media (max-width: 500px) {

    .family-container {
        grid-template-columns: 1fr;
    }

}
```
```css
/* EDUCATION */

.education-section {
    background: #0e1320;
    max-width: none;
}

.education-section .section-title,
.education-container,
.education-intro {
    max-width: 1150px;
    margin-left: auto;
    margin-right: auto;
}

.education-intro {
    color: #8f97aa;
    margin-top: -30px;
    margin-bottom: 45px;
}

.education-container {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 25px;
}

.education-card {
    background: #111725;
    border: 1px solid #20283a;
    border-radius: 15px;
    padding: 30px;

    display: grid;
    grid-template-columns: 70px 1fr;
    gap: 20px;

    transition: 0.3s;
}

.education-card:hover {
    transform: translateY(-6px);
    border-color: #6c63ff;
}

.education-number {
    color: #6c63ff;
    font-size: 20px;
    font-weight: 800;
}

.education-info span {
    color: #6c63ff;
    font-size: 11px;
    font-weight: 700;
    letter-spacing: 2px;
}

.education-info h3 {
    font-size: 24px;
    margin: 8px 0 12px;
}

.education-info p {
    color: #8f97aa;
    font-size: 14px;
    line-height: 1.7;
}

.education-year {
    display: inline-block;
    margin-top: 20px;
    padding: 6px 12px;

    background: #1b2131;
    color: #aeb5c5;

    border-radius: 5px;
    font-size: 12px;
}


/* EDUCATION RESPONSIVE */

@media (max-width: 700px) {

    .education-container {
        grid-template-columns: 1fr;
    }

}

@media (max-width: 500px) {

    .education-card {
        grid-template-columns: 1fr;
    }

}
```
