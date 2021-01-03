<template>
    <div id="app">
        <Home msg="My Workout app" />
        <Excercise/>
    </div>
</template>

<script>
    import Home from './components/Home.vue';
    import Excercise from './components/Excercise.vue';

    export default {
        name: 'app',
        components: {
            Home,
            Excercise
        }
    };
</script>

<style>
</style>