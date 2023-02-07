<!-- <template>
    <div>
        <div>
            <nav class="sidebar">
                <header>
                    <div class="image-text">
                    <div class="text header-text"></div>
                    <span class="name">GHII</span>   
                    <i class='bx bxs-user toggle'></i>                
                    </div>
                </header>            
            </nav>
        </div>
        <div>
        <body>
          <span>Will it push?</span>  
        </body>
    </div>
    </div>
</template>


<style>
*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
body{
    height: 100vh;
    background: #eee;    
}
.sidebar{
 position: fixed;
 top: 0;
 left: 0;
 height: 100%;
 width: 285px;
 padding: 10px 15px;
 background-color: aquamarine;
}
.sidebar .text{
 font-size: 20px;
 font-weight: 500;
}
.sidebar header{
    display: flex;
    align-items: center;
}
.header .text{
    font-weight: 600;
}
.sidebar header .toggle{
    position: absolute;
    top: 50%;
    left: -25px;
    transform: translateY(-50%);

}
</style> -->

<!-- <template>
<div class="flex min-h-screen">
    <div class="w-64 bg-gray-50 border-r border-gray-200">
        <span>Sideber</span>
    </div>

    <div class="flex justify-between py-3 px-6 bg-gray-50 border-b space-x-6">
        <main>Maybe main or not IDK</main>
    </div>
</div>    
</template> -->


<template>
  <div>
    <body>
        <!-- <button type="button" onclick="document.getElementById('display').innerHTML = Date()">This</button>
        <h1 id="display"></h1> -->
        <h1>REPORTS</h1> 

        <div>
  <b-card no-body>
    <b-tabs card>
      <b-tab title="New Timesheets" active>
        <table class="table table-striped">
            <thead>
              <tr>
                <th>ID</th>
                <th>Task</th>
                <th>Description</th>
                <th>Time Spent</th>
                <th>Date</th>
                <th>&nbsp;</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="record in records" :key="record.id">
                <td>{{ record.id }}</td>
                <td>{{ record.task }}</td>
                <td>{{ record.description }}</td>
                <td>{{ record.hours }} hrs {{ record.minutes }} mins</td>
                <td> {{ record.date }}</td>           
              </tr>
            </tbody>
          </table>        
      </b-tab>
      <b-tab title="Approved">
        <b-card-text></b-card-text>
      </b-tab>
    </b-tabs>
  </b-card>
</div>
    </body>
  </div>

</template>

<style>
.b-tab{
  width: 100%;
  overflow-x: auto;
}
</style>

<script>
   let currDate = new Date().toLocaleDateString('en-GB');
    import api from '@/HoursApiService';
    export default {
      data() {
        return {
        result: {},
        model:{
        hours: '',
        minutes: ''
      },
          // loading: false,
          records: [],
          model: {}
        };
      },
      computed: {
       total:function()
     {
          return parseFloat(this.model.hours) + parseFloat(this.model.minutes/60);

     },
  },
      async created() {
        this.getAll()
      },
      methods: {
        async getAll() {
          this.loading = true
  
          try {
            this.records = await api.getAll()
          } finally {
            this.loading = false
          }
        },
        async updateFoodRecord(foodRecord) {
          // We use Object.assign() to create a new (separate) instance
          this.model = Object.assign({}, foodRecord)
        },
        async createFoodRecord() {
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
        async deleteFoodRecord(id) {
          if (confirm('Are you sure you want to delete this record?')) {
            // if we are editing a food record we deleted, remove it from the form
            if (this.model.id === id) {
              this.model = {}
            }
  
            await api.delete(id)
            await this.getAll()
          }
        }
      }
    }
  </script>