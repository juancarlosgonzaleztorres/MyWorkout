<template>
    <div class="excercise">
        <h1>Enter excercise</h1>
        <label for="excerciseName">Excercise Name:</label>
        <input type="text" id="excerciseName"/>
        <br />
        <button type="submit">Save</button>
    </div>
</template>

<script>
    import axios from 'axios';
    export default {
        name: 'Excercise',
        methods: {
            saveExcercise() {
                axios.post(`http://jsonplaceholder.typicode.com/posts`, {
                    body: this.postBody
                })
                    .then(response => { })
                    .catch(e => {
                        this.errors.push(e)
                    })
            }
        }
    };
</script>

<style scoped>
</style>