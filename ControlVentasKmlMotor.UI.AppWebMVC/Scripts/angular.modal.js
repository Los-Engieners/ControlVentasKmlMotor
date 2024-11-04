function modalSelect($scope, $http, data) {
    return {
        $scope: $scope,
        $http: $http,
        name: data.name,
        url: data.url, // url donde se buscara
        propFilter: data.propFilter != undefined ? data.propFilter : "Nombre", // nombre del campo para filtrar
        propFilterAux: data.propFilterAux != undefined ? data.propFilterAux : "", // nombre del campo a auxiliar a seleccionar
        propChange: data.propChange != undefined ? data.propChange : "", // nombre del campo a auxiliar a seleccionar
        propValue: data.propValue != undefined ? data.propValue : "Id", // nombre del campo para seleccionarlo
        visible: false,
        list: [],
        model: data.model, // nombrel del modelo dentro del $scope
        modelText: data.modelText, // nombrel del modelo dentro del $scope
        filter: "",
        search: function () {
            var request = {
                method: "POST",
                url: this.url,
                data: {
                    [this.propFilter]: $scope[this.name].filter,
                }
            };

            if ($scope[this.name].filter.length >= 2) {
                let nameTemp = this.name;
                $http(request).then(function (response) {
                    $scope[nameTemp].list = angular.fromJson(response.data);
                });
            }
            else {
                $scope[this.name].list = [];
            }
        },
        selected: function (obj) {
            $scope[this.model] = obj[this.propValue];
            $scope[this.modelText] = obj[this.propFilter] + (this.propFilterAux != "" ? " " + obj[this.propFilterAux] : "");
            if (this.propChange != "") {
                $scope[this.propChange] = obj[this.propChange];
            }

            $scope[this.name].reset();
        },
        reset: function () {
            $scope[this.name].visible = false;
            $scope[this.name].filter = "";
            $scope[this.name].list = [];
        },
        clear: function () {
            $scope[this.model] = "";
            $scope[this.modelText] = "";
            $scope[this.name].filter = "";
            $scope[this.name].list = [];
            if (this.propChange != "") {
                $scope[this.propChange] = "";
            }
        },
        open: function () {
            $scope[this.name].reset();
            $scope[this.name].visible = true;
        },
        html: "",
    };
}