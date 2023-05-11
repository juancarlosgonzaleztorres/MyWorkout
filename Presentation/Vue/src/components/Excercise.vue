<template>
    <h1>Enter Excercise</h1>
    <label for="excerciseName">Excercise Name</label>
    <input type="text" id="excerciseName"/>

</template>

<script>
    import { Component, Prop, Vue } from 'vue-property-decorator';
    @Component
    export default class Home extends Vue {
        @Prop() private msg!: string;
    }
    Vue.component('button-counter', {
        data: function () {
            return {
                count: 0
            }
        },
        template: '<button v-on:click="count++">You clicked me {{ count }} times.</button>'
    })
</script>

<style scoped>
</style>