<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>INFORMACIÓN | MUSE</title>
    <link rel="stylesheet" type="Estilos.css"/>
    <link href="https://fonts.googleapis.com/css?family=Bebas+Neue&display=swap" rel="stylesheet">
    <style>
      .titulosblancos { 
       color: rgb(255, 255, 255);
       font-weight: bold; font-size: 40px; font-family: 'Bebas Neue', cursive; text-align: center; letter-spacing: 19px;} 
      .subgris { 
        color: rgb(170, 170, 170); font-size: 50px; font-family: 'Bebas Neue', cursive; letter-spacing: 5px; margin: 40px} 
      .linkslila {
        color: rgb(255, 194, 255); line-height: 1.8; font-size: 20px; text-align: justify; margin: 60px;}
       .img {max-widh: 100%}
      .contenedor {max-width: 1200px;   margin: auto;} 

      Body { background-image: url(https://cdn.wegow.com/media/artists/muse/muse-1541428643.98.2560x1440.jpg)}

#GrillaInfo{
   display: grid;
  grid-template-areas: 
    "nav Miembros"
    "nav Discografía";
  grid-row-gap: 5px;
  grid-column-gap: 10px;
}

ul, h2 { 
  padding: 20px 20px 20px 20px;
  justify-content: center;
  background: 	RGBA(0,0,0,0.65)} 

#fotos { display: grid; 
  grid-template-areas: 
    "nav fotos";
   grid-column-gap: 5px;
  grid-row-gap: 10px; 
  padding: 5px 5px 5px 50px;
  justify-content: space-evenly;
  align-items: center;
  background: 	RGBA(0,0,0,0.4);
    }
     </style>
  </head>
  <body bgcolor="black">
    <div id="contenedor">
    <header >
        <h1 class="titulosblancos">INFORMACIÓN DE LA BANDA</h1>
    </header>
    <main>
      <section id="GrillaInfo">
        <h2 id="sub" class="subgris" >MIEMBROS</h2>
          <ul>
            <li id="links" class="linkslila">Matt Bellamy: voz principal y coros, guitarras, sintetizadores y keytar (1994-presente)</li>
            <li id="links" class="linkslila">Dominic Howard: baterías y coros (ocasionalmente) (1994-presente)</li>
           <li id="links" class="linkslila">Christopher Wolstenholme: bajos, armónica y coros (1994-presente)</li>
           </ul>
      </section>
      <section id="fotos">
           <div>
             <img //upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Matthew_bellamy1.jpg/200px-Matthew_bellamy1.jpg" decoding="async" width="200" height="267" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Matthew_bellamy1.jpg/300px-Matthew_bellamy1.jpg 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Matthew_bellamy1.jpg/400px-Matthew_bellamy1.jpg 2x" data-file-width="1487" data-file-height="1983">
              <img  //upload.wikimedia.org/wikipedia/commons/thumb/6/68/Dominic_Howard_Muse_Live_In_Toronto.jpg/200px-Dominic_Howard_Muse_Live_In_Toronto.jpg" decoding="async" width="200" height="267" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/6/68/Dominic_Howard_Muse_Live_In_Toronto.jpg/300px-Dominic_Howard_Muse_Live_In_Toronto.jpg 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/6/68/Dominic_Howard_Muse_Live_In_Toronto.jpg/400px-Dominic_Howard_Muse_Live_In_Toronto.jpg 2x" data-file-width="1577" data-file-height="2103">
             <img //upload.wikimedia.org/wikipedia/commons/thumb/2/21/Chris_Wolstenholme_Toronoto.jpg/200px-Chris_Wolstenholme_Toronoto.jpg" decoding="async" width="200" height="267" srcset="//upload.wikimedia.org/wikipedia/commons/thumb/2/21/Chris_Wolstenholme_Toronoto.jpg/300px-Chris_Wolstenholme_Toronoto.jpg 1.5x, //upload.wikimedia.org/wikipedia/commons/thumb/2/21/Chris_Wolstenholme_Toronoto.jpg/400px-Chris_Wolstenholme_Toronoto.jpg 2x" data-file-width="1577" data-file-height="2103" >
       </div>
      </section>
      <section>
        <h2 id="sub" class="subgris">DISCOGRAFÍA</h2>
        <ul>
          <li id="links" class="linkslila">Álbumes de estudio</li>
            <ol>
              <li id="links" class="linkslila">1999: Showbiz</li>
              <li id="links" class="linkslila">2001: Origin of Symmetry</li>
              <li id="links" class="linkslila">2003: Absolution</li>
             <li id="links" class="linkslila">2006: Black Holes and Revelations</li>
              <li id="links" class="linkslila">2009: The Resistance</li>
              <li id="links" class="linkslila">2012: The 2nd Law</li>
              <li id="links" class="linkslila">2015: Drones</li>
              <li id="links" class="linkslila">2018: Simulation Theory</li>
             </ol>
          <li id="links" class="linkslila">Álbumes en directo</li>
            <ol>
              <li id="links" class="linkslila">2008: HAARP</li>
              <li id="links" class="linkslila">2013: Live at Rome Olympic Stadium</li>
              </ol>
          <li id="links" class="linkslila">Compilaciones</li>
            <ol>
              <li id="links" class="linkslila">2002: Hullabaloo Soundtrack</li>
           </ol>
           <li id="links" class="linkslila">EP</li>
            <ol>
              <li id="links" class="linkslila">1998: Muse</li>
              <li id="links" class="linkslila">1998: Muscle Museum EP</li>
              <li id="links" class="linkslila">2000: Random 1-8</li>
              <li id="links" class="linkslila">2012: Summer Stadiums 2010</li>
              <li id="links" class="linkslila">2015: Live at Koln - Gloria Theatre</li>
          </ol>
         </ul>
      </section>
    </main>
   </div>
  </body>
</html>     