<template>
  <div id="app">
    <header>
      <!-- <b-button v-b-toggle.sidebar-no-header> Sidebar</b-button>
    <b-sidebar id="sidebar-no-header" aria-labelledby="sidebar-no-header-title" no-header shadow>
      <template #default="{ hide }">
        <div class="p-3">
          <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">eTimesheet</b-navbar-brand>
        <b-collapse is-nav id="nav-collapse">
            <b-nav-item to="/add-project">Projects</b-nav-item>
            <b-nav-item to="team">Teams</b-nav-item>
            <b-nav-item to="hours">Hours</b-nav-item>
        </b-collapse>
          <b-button variant="primary" block @click="hide">Close Sidebar</b-button>
        </div>
      </template>
    </b-sidebar> -->
      <!-- <b-navbar vertical-variation>
        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">eTimesheet</b-navbar-brand>
        <b-collapse is-nav id="nav-collapse">
          <b-navbar-nav>
            <b-nav-item to="/add-project">Projects</b-nav-item>
            <b-nav-item to="team">Teams</b-nav-item>
            <b-nav-item to="hours">Hours</b-nav-item>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar> -->
    </header>
    <main>
      <div>
        <!-- <SideBar />
  <SideBarRight />
        <div id="mySidenav" class="sidenav">
          <a href="#/" id="about"><b-icon icon="house" align="left"></b-icon>eTimesheet</a>
          <br>
          <a href="#/add-project" id="blog"><b-icon icon="folder-plus" align="left"></b-icon>Projects</a>
          <br>
          <a href="#/team" id="projects"><b-icon icon="diagram-3" align="left"></b-icon>Teams</a>
          <br>
          <a href="#/hours" id="contact"><b-icon icon="clipboard" align="left"></b-icon>Tasks</a>
          <br>
          <a href="#/report" id="report">Reports</a>
        </div> -->

        <nav id="sidebar">
          <ul>
            <li>
              <a href="#/"><span>Home</span></a>
            </li>
            <li>
              <a href="#/add-project"><b-icon icon="house" align="left" height="28" width="28"></b-icon><span>Project</span></a>
            </li>
            <li>
              <a href="#/team"><span>Teams</span></a>
            </li>
            <li>
              <a href="#/hours"><span>Task</span></a>
            </li>
            <li>
              <a href="#/report"><span>Reports</span></a>
            </li>
          </ul>
        </nav>
        </div>
      <router-view></router-view>
    </main> 
  </div>
</template>

<script>

  export default {
    data () {
      return {
      }
 
    }
  }
</script>

<style>
h1{
  text-align: center;
  margin-top: 40px;
}

body {
  margin: 0;
}

#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #28C69F; ;
}

main {
  text-align: center;
  margin-top: 40px;
}

*{
  padding: 0;
}

nav{
  position: absolute;
  top: 0;
  bottom: 0;
  height: 100%;
  left: 0;
  width: 78px;
  overflow: hidden;
  transition: width 0.2s linear;
  background: #28C69F;
}

ul{
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-around;  
}

li a{
  width: 160px;
  display: flex;
  align-items: center;
  justify-content: space-around;
  text-decoration: none;
  padding: 0;
}

a:hover{
  background: #eee;
}

nav:hover{

  width: 285px;
  transition: all 0.5s ease;
}
header {
  margin: 0;
  height: 56px;
  padding: 0 16px 0 24px;
  background-color: #28C69F; ;
  color: #28C69F; ;
}

header span {
  display: block;
  position: relative;
  font-size: 20px;
  line-height: 1;
  letter-spacing: .02em;
  font-weight: 400;
  box-sizing: border-box;
  padding-top: 16px;
  background-color: #28C69F; ;
}

/* Style the links inside the sidenav */
#mySidenav a {
  position: absolute; /* Position them relative to the browser window */
  left: -155px; /* Position them outside of the screen */
  transition: 0.3s; /* Add transition on hover */
  padding: 15px; /* 15px padding */
  width: 180px; /* Set a specific width */
  text-decoration: none; /* Remove underline */
  font-size: 20px; /* Increase font size */
  color: white; /* White text color */
  border-radius: 0 5px 5px 0; /* Rounded corners on the top right and bottom right side */
}

#mySidenav a:hover {
  left: 0; /* On mouse-over, make the elements appear as they should */
}

/* The about link: 20px from the top with a green background */
#about {
  top: 60px;
  background-color: #28C69F;
}

#blog {
  margin-top: 8px;
  top: 120px;
  background-color: #28C69F; /* Blue */
}

#projects {
  margin-top: 16px;
  top: 180px;
  background-color: #28C69F; /* Red */
}

#contact {
  margin-top: 24px;
  top: 240px;
  background-color: #28C69F /* Light Black */
}

#report {
  margin-top: 32px;
  top: 300px;
  background-color: #28C69F /* Light Black */
}

</style>