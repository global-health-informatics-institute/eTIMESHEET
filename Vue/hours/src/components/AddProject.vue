<template>
    <div class="container-fluid mt-4">
      <h1 class="h1">PROJECTS</h1>
      <!-- <b-alert :show="loading" variant="info">Loading...</b-alert> -->
      <b-row>      
          <!-- <table class="table table-striped">
            <thead>
              <tr>
                <th>Id</th>
                <th>Project</th>
                <th>Project Coordinator</th>
                <th>Start Date</th>
                <th>End Date</th>
                <th>&nbsp;</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="project in projects" :key="project.id">
                <td>{{ project.id }}</td>
                <td>{{ project.name }}</td>
                <td>{{ project.coordinator }}</td>
                <td>{{ project.start }}</td>
                <td>{{ project.end }}</td>
                <td>
                    <router-link :to="`/primary/${project.id}`" class="btn btn-primary"><b-icon icon="eye-fill"></b-icon>Review</router-link>
                     <a href="#/team">Review</a>
  
                </td>
              </tr>
            </tbody>
          </table> -->
          <div>
            <center>
              <b-card-group deck>
            <b-card v-for="project in projects" :key="project.id"
            style="max-width: 20rem; margin-top:10px;">
              <b-card-title style="color:black">{{ project.name }}</b-card-title>
              <b-card-text style="color:black">{{ project.coordinator }}</b-card-text>
              <b-card-text style="color:black">From: {{ project.start }}</b-card-text>
              <b-card-text style="color:black">To: {{ project.end }}</b-card-text>
            </b-card>
          </b-card-group>
          </center>
          </div>
      </b-row>
      <br>
      <br>
      <b-button v-b-modal.modal-1>Add Project</b-button>
  <b-modal id="modal-1" title="Add Project" hide-footer>
    <form @submit.prevent="createAddProject">
              <b-form-group label="Project">
                <b-form-input type="text" v-model="model.name"></b-form-input>
              </b-form-group>
              <b-form-group label="Project Coordinator">
                <b-form-select placeholder="Select Project Coordinator" v-model="model.coordinator">              
                  <option value="Mtheto">Mtheto</option>
                  <option value="Mwabi">Mwabi</option>
                  <option value="Sharon">Sharon</option>
                  <option value="Francis">Francis</option>
                </b-form-select>
              </b-form-group>
              <b-form-group label="Start Date">
                <b-form-input rows="4" v-model="model.start" type="date"></b-form-input>
              </b-form-group>
              <b-form-group label="End Date">
                <b-form-input rows="4" v-model="model.end" type="date"></b-form-input>
              </b-form-group>
              <div>
                <b-btn type="submit" variant="success">Save Record</b-btn>
              </div>
            </form>
  </b-modal>
    </div>
  </template>
  
  <script>
    import api from '@/AddProjectApiService';
    export default {
      data() {
        return {
          // loading: false,
          projects: [],
          model: {}
        };
      },
      async created() {
        this.getAll()
      },
      methods: {
        async getAll() {
          this.loading = true
  
          try {
            this.projects = await api.getAll()
          } finally {
            this.loading = false
          }
        },
        async updateAddProject(addProject) {
          // We use Object.assign() to create a new (separate) instance
          this.model = Object.assign({}, addProject)
        },
        async createAddProject() {
          const isUpdate = !!this.model.id;
  
          if (isUpdate) {
            await api.update(this.model.id, this.model)
          } else {
            await api.create(this.model)
          }
  
          // Clear the data inside of the form
          this.model = {}
  
          // Fetch all records again to have latest data
          await this.getAll()
        },
      }
    }
  </script>