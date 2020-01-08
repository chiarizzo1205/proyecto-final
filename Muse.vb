<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>MUSE Official</title>
    <link rel="stylesheet" type="Estilos.css"/>
    <link href="https://fonts.googleapis.com/css?family=Bebas+Neue&display=swap" rel="stylesheet">
    <style>
      .titulosblancos { 
       color: rgb(255, 255, 255);
       font-weight: bold; font-size: 110px; font-family: 'Bebas Neue', cursive; text-align: center; letter-spacing: 19px; animation-name: aparecer;   animation-duration: 3s;   animation-iteration-count: 1
        } 
      .subgris { 
        color: rgb(170, 170, 170); font-size: 50px; font-family: 'Bebas Neue', cursive; letter-spacing: 5px;} 
      .linkslila {
        color: rgb(255, 194, 255); line-height: 1.8; font-size: 20px;}
      .linkslilaanimado {   animation-name: aparecer;   animation-duration: 1s;   animation-iteration-count: infinite; color: rgb(255, 194, 255); line-height: 1.8; font-size: 20px; }
      .contenedor {max-width: 1200px;   margin: auto;} 
    </style>
    <style>
              ul {
              list-style-type: none;
              margin: 0;
              padding: 0;
              overflow: hidden;
              background-color: #333;  }
              li {
              float: left;   }
              li a {
             display: block;
             color: white;
             text-align: center;
             padding: 10px 20px;
             text-decoration: none;  }
            li a:hover:not(.active) {
            background-color: #111;    }
           .active {
            background-color: #4CAF50;  }
          .footer { background-color: black; bottom: 0px; width: 100%; height: 40px; color: white; text-align: center; }
          .img {max-widh: 100%}
          @keyframes aparecer {
             0% {     opacity: 0;  }
             50% {    opacity: 1;  }
             100% {    opacity: 0;  }}


     </style>
  </head>
  <body bgcolor="black">
    <div id="contenedor">
    <header>
        <div>
          <h1 id="titulo" class="titulosblancos">MUSE</h1>
      </div>
    </header>
    <main>
        <section>
            <h2 id="sub" class="subgris">MENÚ PRINCIPAL</h2>
                <ul>
                    <li id="links" class="linkslilaanimado"><a href="Tour.html" target=”_blank”>2019 Simulation Theory World Tour</a></li>
                    <li id="links" class="linkslila"><a href="Información.html" target=”_blank”>Información de la Banda</a></li>
                    <li id="links" class="linkslila"><a href="Noticias.html" target=”_blank”>Noticias</a></li>
                    <li id="links" class="linkslila"><a href="Galería.html" target=”_blank”>Galería</a></li>
                    <li id="links" class="linkslila"><a href="Suscripción.html" target=”_blank”>Suscripción y compra de entradas</a></li>
        </section>
        <section>
          <h2>PRESSURE</h2>
                   <iframe position="absolute" text-align="center" width="853" height="480"  src="https://www.youtube.com/embed/h2eKImKZviw" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen ></iframe></br>
         </section> 
    </main>
   </div>
  </body>
 <footer>
      </br>
      <footer class= "footer"> <p> © 2019 WARNER MUSIC UK LIMITED. </p> </footer>
09/12 16:48
 </footer>
</html>
