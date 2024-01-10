// Module Manager for registering the modules of the chart
import { ModuleManager } from 'igniteui-webcomponents-core';
// Bullet Graph Module
import { IgcRadialGaugeCoreModule } from 'igniteui-webcomponents-gauges';
import { IgcRadialGaugeModule } from 'igniteui-webcomponents-gauges';

// register the modules
ModuleManager.register(
    IgcRadialGaugeCoreModule,
    IgcRadialGaugeModule
);
window.updateValue = function (value) {
    var rg = document.getElementById("rg");
    rg.value = value;
}
import BpmnJS from 'bpmn-js';




// the diagram to display
// you may load it asynchronously via ajax, too





var bpmnViewer = new BpmnJS({
    container: '#canvas'
});

//await bpmnViewer.importXML("https://cdn.statically.io/gh/bpmn-io/bpmn-js-examples/dfceecba/url-viewer/resources/pizza-collaboration.bpmn");

// access viewer components
var canvas = bpmnViewer.get('canvas');
