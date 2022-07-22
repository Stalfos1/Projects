% Solve an Input-Output Fitting problem with a Neural Network
% Script generated by Neural Fitting app
% Created 18-Jul-2022 21:19:04
%
% This script assumes these variables are defined:
%
%   bodyfatInputs - input data.
%   bodyfatTargets - target data.
load bodyfat_dataset
x = bodyfatInputs;
t = bodyfatTargets;

% Choose a Training Function
% For a list of all training functions type: help nntrain
% 'trainlm' is usually fastest.
% 'trainbr' takes longer but may be better for challenging problems.
% 'trainscg' uses less memory. Suitable in low memory situations.
trainFcn = 'trainlm';  % Levenberg-Marquardt backpropagation.



% Create a Fitting Network
hiddenLayerSize = 10;
net = fitnet(hiddenLayerSize,trainFcn);

[x,t] = bodyfat_dataset;

% Setup Division of Data for Training, Validation, Testing
net.divideParam.trainRatio = 70/100;
net.divideParam.valRatio = 15/100;
net.divideParam.testRatio = 15/100;

% Train the Network
[net,tr] = train(net,x,t);

% Test the Network
y = net(x);
e = gsubtract(t,y);
performance = perform(net,t,y)

% View the Network
view(net)

%network perfomance
tInd = tr.testInd;
tstOutputs = net(x(:,tInd));
tstPerform = perform(net,t(tInd),tstOutputs)


% Plots
% Uncomment these lines to enable various plots.
%figure, plotperform(tr)
%figure, plottrainstate(tr)
%figure, ploterrhist(e)
%figure, plotregression(t,y)
%figure, plotfit(net,x,t)
