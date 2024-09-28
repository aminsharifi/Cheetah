﻿import $ from 'jquery';
import { ModuleManager } from 'igniteui-webcomponents-core';
import { IgcRadialGaugeCoreModule } from 'igniteui-webcomponents-gauges';
import { IgcRadialGaugeModule } from 'igniteui-webcomponents-gauges';
import BpmnJS from 'bpmn-js/lib/Modeler';
import BpmnViewer from 'bpmn-js/lib/NavigatedViewer';

//const MiniCssExtractPlugin = require("mini-css-extract-plugin");   
import diagram_js from 'bpmn-js/dist/assets/diagram-js.css';
import bpmn_js from 'bpmn-js/dist/assets/bpmn-js.css';
import bpmn from 'bpmn-js/dist/assets/bpmn-font/css/bpmn.css';
import bpmn_embedded from 'bpmn-js/dist/assets/bpmn-font/css/bpmn-embedded.css';

$('.step-menu li').click(function () {
    $('.current').removeClass('current')
    $('.complete').removeClass('complete')
    $(this).addClass('current')
    $(this).prevAll().addClass('complete')
})

// Module Manager for registering the modules of the chart


// register the modules
ModuleManager.register(
    IgcRadialGaugeCoreModule,
    IgcRadialGaugeModule
);
window.updateValue = function (value) {
    var rg = document.getElementById("rg");
    rg.value = value;    
    try {

        var bpmnJS = new BpmnJS({
            container: '#canvas'
        });

	    //const viewer = new BpmnViewer({
	    //  container: '#canvas'
	    //});
    
        const bpmn =
            "<?xml version='1.0' encoding='UTF-8'?><bpmn:definitions xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:bpmn='http://www.omg.org/spec/BPMN/20100524/MODEL' xmlns:bpmndi='http://www.omg.org/spec/BPMN/20100524/DI' xmlns:dc='http://www.omg.org/spec/DD/20100524/DC' xmlns:di='http://www.omg.org/spec/DD/20100524/DI' xmlns:bioc='http://bpmn.io/schema/bpmn/biocolor/1.0' xmlns:color='http://www.omg.org/spec/BPMN/non-normative/color/1.0' id='Definitions_0nhjy4h' targetNamespace='http://bpmn.io/schema/bpmn' exporter='bpmn-js (https://demo.bpmn.io)' exporterVersion='16.3.2'><bpmn:process id='Process_1fmtubt' isExecutable='false'><bpmn:startEvent id='StartEvent_0yfc0w1'><bpmn:outgoing>Flow_18pysee</bpmn:outgoing></bpmn:startEvent><bpmn:task id='Activity_1i9mtr0' name='ثبت درخواست'><bpmn:incoming>Flow_18pysee</bpmn:incoming><bpmn:outgoing>Flow_0pscxxm</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_18pysee' sourceRef='StartEvent_0yfc0w1' targetRef='Activity_1i9mtr0' /><bpmn:task id='Activity_0z4osd3' name='پخش درخواست'><bpmn:incoming>Flow_0pscxxm</bpmn:incoming><bpmn:outgoing>Flow_09xab7x</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_0pscxxm' name='ارسال درخواست' sourceRef='Activity_1i9mtr0' targetRef='Activity_0z4osd3' /><bpmn:task id='Activity_023rgl4' name='کارشناس پذیرش'><bpmn:incoming>Flow_08qx8zw</bpmn:incoming><bpmn:outgoing>Flow_1fhmo6s</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_09xab7x' name='ارسال درخواست' sourceRef='Activity_0z4osd3' targetRef='Gateway_19p0pjj' /><bpmn:exclusiveGateway id='Gateway_0ke8xio'><bpmn:incoming>Flow_1fhmo6s</bpmn:incoming><bpmn:outgoing>Flow_0rpzeh6</bpmn:outgoing><bpmn:outgoing>Flow_07134jc</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_1fhmo6s' sourceRef='Activity_023rgl4' targetRef='Gateway_0ke8xio' /><bpmn:task id='Activity_0ap830l' name='رد کارشناس پذیرش و بررسی مدیر'><bpmn:incoming>Flow_0rpzeh6</bpmn:incoming><bpmn:outgoing>Flow_0v4226f</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_0rpzeh6' name='رد' sourceRef='Gateway_0ke8xio' targetRef='Activity_0ap830l' /><bpmn:task id='Activity_05muuwu' name='تایید کارشناس پذیرش و بررسی مدیر'><bpmn:incoming>Flow_0u4cfyn</bpmn:incoming><bpmn:outgoing>Flow_0q7wf4e</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_07134jc' name='تایید' sourceRef='Gateway_0ke8xio' targetRef='Gateway_0tt8dy1' /><bpmn:exclusiveGateway id='Gateway_01o9aqs'><bpmn:incoming>Flow_0q7wf4e</bpmn:incoming><bpmn:outgoing>Flow_1ixzja2</bpmn:outgoing><bpmn:outgoing>Flow_00hg5u1</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_0q7wf4e' sourceRef='Activity_05muuwu' targetRef='Gateway_01o9aqs' /><bpmn:exclusiveGateway id='Gateway_118hn4u'><bpmn:incoming>Flow_0v4226f</bpmn:incoming><bpmn:outgoing>Flow_05ccrnr</bpmn:outgoing><bpmn:outgoing>Flow_1qgon8n</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_0v4226f' sourceRef='Activity_0ap830l' targetRef='Gateway_118hn4u' /><bpmn:exclusiveGateway id='Gateway_19p0pjj'><bpmn:incoming>Flow_09xab7x</bpmn:incoming><bpmn:incoming>Flow_1ixzja2</bpmn:incoming><bpmn:incoming>Flow_15zw9fn</bpmn:incoming><bpmn:outgoing>Flow_08qx8zw</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_08qx8zw' sourceRef='Gateway_19p0pjj' targetRef='Activity_023rgl4' /><bpmn:sequenceFlow id='Flow_05ccrnr' name='رد' sourceRef='Gateway_118hn4u' targetRef='Gateway_07nrvio' /><bpmn:task id='Activity_0y4rrij' name='ویرایش درخواست'><bpmn:incoming>Flow_1qgon8n</bpmn:incoming><bpmn:outgoing>Flow_08xegzm</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_1qgon8n' name='تایید' sourceRef='Gateway_118hn4u' targetRef='Activity_0y4rrij' /><bpmn:sequenceFlow id='Flow_1ixzja2' name='رد' sourceRef='Gateway_01o9aqs' targetRef='Gateway_19p0pjj' /><bpmn:exclusiveGateway id='Gateway_07nrvio'><bpmn:incoming>Flow_05ccrnr</bpmn:incoming><bpmn:incoming>Flow_08xegzm</bpmn:incoming><bpmn:outgoing>Flow_15zw9fn</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_15zw9fn' sourceRef='Gateway_07nrvio' targetRef='Gateway_19p0pjj' /><bpmn:sequenceFlow id='Flow_08xegzm' sourceRef='Activity_0y4rrij' targetRef='Gateway_07nrvio' /><bpmn:task id='Activity_1apyaj9' name='بررسی معاونت پذیرش'><bpmn:incoming>Flow_00hg5u1</bpmn:incoming><bpmn:incoming>Flow_0mtokdh</bpmn:incoming><bpmn:outgoing>Flow_0beflmb</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_00hg5u1' sourceRef='Gateway_01o9aqs' targetRef='Activity_1apyaj9' /><bpmn:exclusiveGateway id='Gateway_1clg99n'><bpmn:incoming>Flow_0beflmb</bpmn:incoming><bpmn:outgoing>Flow_0zcgh1n</bpmn:outgoing><bpmn:outgoing>Flow_0mvt4ex</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_0beflmb' sourceRef='Activity_1apyaj9' targetRef='Gateway_1clg99n' /><bpmn:exclusiveGateway id='Gateway_0tt8dy1'><bpmn:incoming>Flow_07134jc</bpmn:incoming><bpmn:incoming>Flow_0zcgh1n</bpmn:incoming><bpmn:outgoing>Flow_0u4cfyn</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_0u4cfyn' sourceRef='Gateway_0tt8dy1' targetRef='Activity_05muuwu' /><bpmn:sequenceFlow id='Flow_0zcgh1n' name='رد' sourceRef='Gateway_1clg99n' targetRef='Gateway_0tt8dy1' /><bpmn:task id='Activity_1fhiiua' name='بررسی هیات پذیرش'><bpmn:incoming>Flow_0mvt4ex</bpmn:incoming><bpmn:outgoing>Flow_1jnd2b8</bpmn:outgoing></bpmn:task><bpmn:sequenceFlow id='Flow_0mvt4ex' name='تایید' sourceRef='Gateway_1clg99n' targetRef='Activity_1fhiiua' /><bpmn:exclusiveGateway id='Gateway_1bc97vj'><bpmn:incoming>Flow_1jnd2b8</bpmn:incoming><bpmn:outgoing>Flow_0mtokdh</bpmn:outgoing><bpmn:outgoing>Flow_17clu2u</bpmn:outgoing></bpmn:exclusiveGateway><bpmn:sequenceFlow id='Flow_1jnd2b8' sourceRef='Activity_1fhiiua' targetRef='Gateway_1bc97vj' /><bpmn:sequenceFlow id='Flow_0mtokdh' name='رد' sourceRef='Gateway_1bc97vj' targetRef='Activity_1apyaj9' /><bpmn:endEvent id='Event_0ono8m0'><bpmn:incoming>Flow_17clu2u</bpmn:incoming></bpmn:endEvent><bpmn:sequenceFlow id='Flow_17clu2u' name='تایید' sourceRef='Gateway_1bc97vj' targetRef='Event_0ono8m0' /><bpmn:textAnnotation id='TextAnnotation_10n4rsn'><bpmn:text>تالتل" +
            "تاتانتا</bpmn:text></bpmn:textAnnotation><bpmn:association id='Association_06klfjw' associationDirection='None' sourceRef='Activity_1i9mtr0' targetRef='TextAnnotation_10n4rsn' /></bpmn:process><bpmndi:BPMNDiagram id='BPMNDiagram_1'><bpmndi:BPMNPlane id='BPMNPlane_1' bpmnElement='Process_1fmtubt'><bpmndi:BPMNShape id='TextAnnotation_10n4rsn_di' bpmnElement='TextAnnotation_10n4rsn'><dc:Bounds x='218' y='160' width='100' height='41' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='_BPMNShape_StartEvent_2' bpmnElement='StartEvent_0yfc0w1'><dc:Bounds x='156' y='282' width='36' height='36' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_1i9mtr0_di' bpmnElement='Activity_1i9mtr0'><dc:Bounds x='218' y='260' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_0z4osd3_di' bpmnElement='Activity_0z4osd3'><dc:Bounds x='390' y='260' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_19p0pjj_di' bpmnElement='Gateway_19p0pjj' isMarkerVisible='true'><dc:Bounds x='564' y='275' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_023rgl4_di' bpmnElement='Activity_023rgl4'><dc:Bounds x='642' y='260' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_0ke8xio_di' bpmnElement='Gateway_0ke8xio' isMarkerVisible='true'><dc:Bounds x='768' y='275' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_0ap830l_di' bpmnElement='Activity_0ap830l'><dc:Bounds x='743' y='354' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_118hn4u_di' bpmnElement='Gateway_118hn4u' isMarkerVisible='true'><dc:Bounds x='768' y='463' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_0y4rrij_di' bpmnElement='Activity_0y4rrij'><dc:Bounds x='743' y='571' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_07nrvio_di' bpmnElement='Gateway_07nrvio' isMarkerVisible='true'><dc:Bounds x='655' y='463' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_0tt8dy1_di' bpmnElement='Gateway_0tt8dy1' isMarkerVisible='true'><dc:Bounds x='886' y='275' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_05muuwu_di' bpmnElement='Activity_05muuwu'><dc:Bounds x='861' y='170' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_01o9aqs_di' bpmnElement='Gateway_01o9aqs' isMarkerVisible='true'><dc:Bounds x='886' y='85' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_1apyaj9_di' bpmnElement='Activity_1apyaj9'><dc:Bounds x='979' y='70' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_1clg99n_di' bpmnElement='Gateway_1clg99n' isMarkerVisible='true'><dc:Bounds x='1004' y='275' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Activity_1fhiiua_di' bpmnElement='Activity_1fhiiua'><dc:Bounds x='1107' y='260' width='100' height='80' /><bpmndi:BPMNLabel /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Gateway_1bc97vj_di' bpmnElement='Gateway_1bc97vj' isMarkerVisible='true'><dc:Bounds x='1132' y='85' width='50' height='50' /></bpmndi:BPMNShape><bpmndi:BPMNShape id='Event_0ono8m0_di' bpmnElement='Event_0ono8m0'><dc:Bounds x='1234' y='92' width='36' height='36' /></bpmndi:BPMNShape><bpmndi:BPMNEdge id='Association_06klfjw_di' bpmnElement='Association_06klfjw'><di:waypoint x='268' y='260' /><di:waypoint x='268' y='201' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_18pysee_di' bpmnElement='Flow_18pysee'><di:waypoint x='192' y='300' /><di:waypoint x='218' y='300' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0pscxxm_di' bpmnElement='Flow_0pscxxm' bioc:stroke='#205022' color:border-color='#205022'><di:waypoint x='318' y='300' /><di:waypoint x='390' y='300' /><bpmndi:BPMNLabel color:color='#205022'><dc:Bounds x='324' y='282' width='61' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_09xab7x_di' bpmnElement='Flow_09xab7x' bioc:stroke='#205022' color:border-color='#205022'><di:waypoint x='490' y='300' /><di:waypoint x='564' y='300' /><bpmndi:BPMNLabel color:color='#205022'><dc:Bounds x='497' y='282' width='61' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_1ixzja2_di' bpmnElement='Flow_1ixzja2' bioc:stroke='#831311' color:border-color='#831311'><di:waypoint x='886' y='110' /><di:waypoint x='589' y='110' /><di:waypoint x='589' y='275' /><bpmndi:BPMNLabel color:color='#831311'><dc:Bounds x='742' y='92' width='10' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_15zw9fn_di' bpmnElement='Flow_15zw9fn'><di:waypoint x='655' y='488' /><di:waypoint x='589' y='488' /><di:waypoint x='589' y='325' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_08qx8zw_di' bpmnElement='Flow_08qx8zw'><di:waypoint x='614' y='300' /><di:waypoint x='642' y='300' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_1fhmo6s_di' bpmnElement='Flow_1fhmo6s'><di:waypoint x='742' y='300' /><di:waypoint x='768' y='300' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0rpzeh6_di' bpmnElement='Flow_0rpzeh6' bioc:stroke='#831311' color:border-color='#831311'><di:waypoint x='793' y='325' /><di:waypoint x='793' y='354' /><bpmndi:BPMNLabel><dc:Bounds x='798' y='318' width='10' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_07134jc_di' bpmnElement='Flow_07134jc' bioc:stroke='#205022' color:border-color='#205022'><di:waypoint x='818' y='300' /><di:waypoint x='886' y='300' /><bpmndi:BPMNLabel color:color='#205022'><dc:Bounds x='840' y='280' width='15' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_1qgon8n_di' bpmnElement='Flow_1qgon8n' bioc:stroke='#205022' color:border-color='#205022'><di:waypoint x='793' y='513' /><di:waypoint x='793' y='571' /><bpmndi:BPMNLabel color:color='#205022'><dc:Bounds x='788' y='514' width='15' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_08xegzm_di' bpmnElement='Flow_08xegzm'><di:waypoint x='740' y='611' /><di:waypoint x='680' y='611' /><di:waypoint x='680' y='513' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0q7wf4e_di' bpmnElement='Flow_0q7wf4e'><di:waypoint x='911' y='170' /><di:waypoint x='911' y='135' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0v4226f_di' bpmnElement='Flow_0v4226f'><di:waypoint x='793' y='434' /><di:waypoint x='793' y='463' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_05ccrnr_di' bpmnElement='Flow_05ccrnr' bioc:stroke='#831311' color:border-color='#831311'><di:waypoint x='768' y='488' /><di:waypoint x='705' y='488' /><bpmndi:BPMNLabel color:color='#831311'><dc:Bounds x='733' y='470' width='10' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_00hg5u1_di' bpmnElement='Flow_00hg5u1'><di:waypoint x='936' y='110' /><di:waypoint x='979' y='110' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0beflmb_di' bpmnElement='Flow_0beflmb'><di:waypoint x='1029' y='150' /><di:waypoint x='1029' y='275' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0u4cfyn_di' bpmnElement='Flow_0u4cfyn'><di:waypoint x='911' y='275' /><di:waypoint x='911' y='250' /></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0zcgh1n_di' bpmnElement='Flow_0zcgh1n' bioc:stroke='#831311' color:border-color='#831311'><di:waypoint x='1004' y='300' /><di:waypoint x='936' y='300' /><bpmndi:BPMNLabel><dc:Bounds x='965' y='282' width='10' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0mvt4ex_di' bpmnElement='Flow_0mvt4ex' bioc:stroke='#205022' color:border-color='#205022'><di:waypoint x='1054' y='300' /><di:waypoint x='1107' y='300' /><bpmndi:BPMNLabel><dc:Bounds x='1073' y='282' width='15' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_1jnd2b8_di' bpmnElement='Flow_1jnd2b8'><di:waypoint x='1157' y='260' /><di:waypoint x='1157' y='135' /><bpmndi:BPMNLabel><dc:Bounds x='1240' y='150' width='10' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_0mtokdh_di' bpmnElement='Flow_0mtokdh' bioc:stroke='#831311' color:border-color='#831311'><di:waypoint x='1132' y='110' /><di:waypoint x='1079' y='110' /><bpmndi:BPMNLabel><dc:Bounds x='1101' y='92' width='10' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge><bpmndi:BPMNEdge id='Flow_17clu2u_di' bpmnElement='Flow_17clu2u' bioc:stroke='#205022' color:border-color='#205022'><di:waypoint x='1182' y='110' /><di:waypoint x='1234' y='110' /><bpmndi:BPMNLabel><dc:Bounds x='1200' y='92' width='15' height='14' /></bpmndi:BPMNLabel></bpmndi:BPMNEdge></bpmndi:BPMNPlane></bpmndi:BPMNDiagram></bpmn:definitions>";
        const result = bpmnJS.importXML(bpmn);
        const { warnings } = result;
        console.log(warnings);
    } catch (err) {
        console.log(err.message, err.warnings);
    }
}

// the diagram to display
// you may load it asynchronously via ajax, too

//var bpmnViewer = new BpmnJS({
//    container: '#canvas'
//});