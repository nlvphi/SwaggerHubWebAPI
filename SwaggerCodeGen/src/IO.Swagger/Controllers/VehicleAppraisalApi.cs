/*
 * Appraisal Api
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class VehicleAppraisalApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Add or update vehicle appraisal (Lastest changed by phi.nguyen)</remarks>
        /// <param name="body"></param>
        /// <response code="200">Success. Return the new Vehicle Appraisal object</response>
        /// <response code="400">There is some error while processing Vehicle Appraisal. Follow message instruction for more information</response>
        /// <response code="404">Could not find the appraisal/vehicle/contact to update. Follow message instruction for more information</response>
        [HttpPost]
        [Route("/VehicleAppraisal/AddUpdateVehicleAppraisal")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalAddUpdateVehicleAppraisalPost")]
        public virtual IActionResult VehicleAppraisalAddUpdateVehicleAppraisalPost([FromBody]AppraisalRequestViewModel body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all bureaucracies</remarks>
        /// <response code="200">List of bureaucracies</response>
        /// <response code="400">There is some error while getting bureaucracies. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/Bureaucracies")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalBureaucraciesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<BureaucracySelectionViewModel>), description: "List of bureaucracies")]
        public virtual IActionResult VehicleAppraisalBureaucraciesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<BureaucracySelectionViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Name\" : \"Name\"\n}, {\n  \"Description\" : \"Description\",\n  \"Name\" : \"Name\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<BureaucracySelectionViewModel>>(exampleJson)
                        : default(List<BureaucracySelectionViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all contact titles</remarks>
        /// <response code="200">List of contact titles</response>
        /// <response code="400">There is some error while getting contact titles. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/ContactTitles")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalContactTitlesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ContactTitleViewModel>), description: "List of contact titles")]
        public virtual IActionResult VehicleAppraisalContactTitlesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ContactTitleViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ContactTitleViewModel>>(exampleJson)
                        : default(List<ContactTitleViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all employees</remarks>
        /// <response code="200">List of employees</response>
        /// <response code="400">There is some error while getting employees. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/Employees")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalEmployeesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<EmployeeViewModel>), description: "List of employees")]
        public virtual IActionResult VehicleAppraisalEmployeesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<EmployeeViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"EmpId\" : \"EmpId\",\n  \"Name\" : \"Name\"\n}, {\n  \"EmpId\" : \"EmpId\",\n  \"Name\" : \"Name\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<EmployeeViewModel>>(exampleJson)
                        : default(List<EmployeeViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all families by make code</remarks>
        /// <param name="makeCode">Code get from GET Makes API</param>
        /// <response code="200">List of families</response>
        /// <response code="400">There is some error while getting families. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/Families")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalFamiliesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ModelTypeViewModel>), description: "List of families")]
        public virtual IActionResult VehicleAppraisalFamiliesGet([FromQuery][Required()]int? makeCode)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ModelTypeViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"VehicleType\" : 0,\n  \"Family\" : \"Family\"\n}, {\n  \"Description\" : \"Description\",\n  \"VehicleType\" : 0,\n  \"Family\" : \"Family\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ModelTypeViewModel>>(exampleJson)
                        : default(List<ModelTypeViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all locations</remarks>
        /// <response code="200">List of locations</response>
        /// <response code="400">There is some error while getting locations. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/Locations")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalLocationsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<LocationSelectionViewModel>), description: "List of locations")]
        public virtual IActionResult VehicleAppraisalLocationsGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<LocationSelectionViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Id\" : 0,\n  \"Name\" : \"Name\"\n}, {\n  \"Id\" : 0,\n  \"Name\" : \"Name\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<LocationSelectionViewModel>>(exampleJson)
                        : default(List<LocationSelectionViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all makes</remarks>
        /// <response code="200">List of makes</response>
        /// <response code="400">There is some error while getting makes. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/Makes")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalMakesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<DmsMakeViewModel>), description: "List of makes")]
        public virtual IActionResult VehicleAppraisalMakesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<DmsMakeViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<DmsMakeViewModel>>(exampleJson)
                        : default(List<DmsMakeViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all model pricing guides</remarks>
        /// <param name="makeCode">Code get from GET Makes API</param>
        /// <param name="year"></param>
        /// <param name="family"></param>
        /// <param name="badgeOrVariant"></param>
        /// <param name="series"></param>
        /// <param name="bodyStyle"></param>
        /// <param name="engine"></param>
        /// <param name="transmission"></param>
        /// <response code="200">List of model pricing guides</response>
        /// <response code="400">There is some error while getting model pricing guides. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/ModelPricingGuides")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalModelPricingGuidesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ModelPricingGuideResponseViewModel>), description: "List of model pricing guides")]
        public virtual IActionResult VehicleAppraisalModelPricingGuidesGet([FromQuery][Required()]int? makeCode, [FromQuery]int? year, [FromQuery]string family, [FromQuery]string badgeOrVariant, [FromQuery]string series, [FromQuery]string bodyStyle, [FromQuery]string engine, [FromQuery]string transmission)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ModelPricingGuideResponseViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"ManufacturerModelSeries\" : \"ManufacturerModelSeries\",\n  \"ManufacturerTransmissionCode\" : \"ManufacturerTransmissionCode\",\n  \"EngineSize\" : \"EngineSize\",\n  \"VehicleType\" : 1,\n  \"ManufacturerModelCode\" : \"ManufacturerModelCode\",\n  \"ModelPricingGuideKey\" : 0,\n  \"ManufactureYear\" : 5,\n  \"ManufacturerEngineCode\" : \"ManufacturerEngineCode\",\n  \"FuelType\" : \"FuelType\",\n  \"Variant\" : \"Variant\",\n  \"DriveType\" : \"DriveType\",\n  \"Series\" : \"Series\",\n  \"BadgeDescription\" : \"BadgeDescription\",\n  \"BodyStyle\" : \"BodyStyle\",\n  \"NewPrice\" : 2.3021358869347655,\n  \"Family\" : \"Family\",\n  \"ModelPricingGuideCode\" : \"ModelPricingGuideCode\",\n  \"DmsMakeCode\" : 6,\n  \"ManufactureMonth\" : 5,\n  \"BadgeSecondaryDescription\" : \"BadgeSecondaryDescription\",\n  \"Engine\" : \"Engine\"\n}, {\n  \"ManufacturerModelSeries\" : \"ManufacturerModelSeries\",\n  \"ManufacturerTransmissionCode\" : \"ManufacturerTransmissionCode\",\n  \"EngineSize\" : \"EngineSize\",\n  \"VehicleType\" : 1,\n  \"ManufacturerModelCode\" : \"ManufacturerModelCode\",\n  \"ModelPricingGuideKey\" : 0,\n  \"ManufactureYear\" : 5,\n  \"ManufacturerEngineCode\" : \"ManufacturerEngineCode\",\n  \"FuelType\" : \"FuelType\",\n  \"Variant\" : \"Variant\",\n  \"DriveType\" : \"DriveType\",\n  \"Series\" : \"Series\",\n  \"BadgeDescription\" : \"BadgeDescription\",\n  \"BodyStyle\" : \"BodyStyle\",\n  \"NewPrice\" : 2.3021358869347655,\n  \"Family\" : \"Family\",\n  \"ModelPricingGuideCode\" : \"ModelPricingGuideCode\",\n  \"DmsMakeCode\" : 6,\n  \"ManufactureMonth\" : 5,\n  \"BadgeSecondaryDescription\" : \"BadgeSecondaryDescription\",\n  \"Engine\" : \"Engine\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ModelPricingGuideResponseViewModel>>(exampleJson)
                        : default(List<ModelPricingGuideResponseViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all models by make code and family</remarks>
        /// <param name="makeCode">Code get from GET Makes API</param>
        /// <param name="family"></param>
        /// <response code="200">List of models</response>
        /// <response code="400">There is some error while getting models. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/Models")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalModelsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ModelViewModel>), description: "List of models")]
        public virtual IActionResult VehicleAppraisalModelsGet([FromQuery][Required()]int? makeCode, [FromQuery]string family)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ModelViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"EngineCode\" : \"EngineCode\",\n  \"Series\" : \"Series\",\n  \"TransmissionCode\" : \"TransmissionCode\",\n  \"Description\" : \"Description\",\n  \"BodyStyleCode\" : 1,\n  \"NoOfDoors\" : 5,\n  \"FuelCode\" : 6,\n  \"VehicleType\" : 0,\n  \"ModelYear\" : 2,\n  \"Badge\" : \"Badge\",\n  \"ModelId\" : \"ModelId\",\n  \"NoOfCylinders\" : 5\n}, {\n  \"EngineCode\" : \"EngineCode\",\n  \"Series\" : \"Series\",\n  \"TransmissionCode\" : \"TransmissionCode\",\n  \"Description\" : \"Description\",\n  \"BodyStyleCode\" : 1,\n  \"NoOfDoors\" : 5,\n  \"FuelCode\" : 6,\n  \"VehicleType\" : 0,\n  \"ModelYear\" : 2,\n  \"Badge\" : \"Badge\",\n  \"ModelId\" : \"ModelId\",\n  \"NoOfCylinders\" : 5\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ModelViewModel>>(exampleJson)
                        : default(List<ModelViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all organisation types</remarks>
        /// <response code="200">List of organisation types</response>
        /// <response code="400">There is some error while getting organisation types. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/OrganisationTypes")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalOrganisationTypesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<OrganisationTypeViewModel>), description: "List of organisation types")]
        public virtual IActionResult VehicleAppraisalOrganisationTypesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<OrganisationTypeViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<OrganisationTypeViewModel>>(exampleJson)
                        : default(List<OrganisationTypeViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all privacies</remarks>
        /// <response code="200">List of privacies</response>
        /// <response code="400">There is some error while getting privacies. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/Privacies")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalPrivaciesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<PrivacyViewModel>), description: "List of privacies")]
        public virtual IActionResult VehicleAppraisalPrivaciesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<PrivacyViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<PrivacyViewModel>>(exampleJson)
                        : default(List<PrivacyViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all tax types</remarks>
        /// <response code="200">List of tax types</response>
        /// <response code="400">There is some error while getting tax types. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/TaxTypes")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalTaxTypesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<TaxTypeViewModel>), description: "List of tax types")]
        public virtual IActionResult VehicleAppraisalTaxTypesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<TaxTypeViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<TaxTypeViewModel>>(exampleJson)
                        : default(List<TaxTypeViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all vehicle body styles</remarks>
        /// <response code="200">List of vehicle body styles</response>
        /// <response code="400">There is some error while getting body styles. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/VehicleBodyStyles")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalVehicleBodyStylesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<VehicleBodyStyleViewModel>), description: "List of vehicle body styles")]
        public virtual IActionResult VehicleAppraisalVehicleBodyStylesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<VehicleBodyStyleViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<VehicleBodyStyleViewModel>>(exampleJson)
                        : default(List<VehicleBodyStyleViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all vehicle fuels</remarks>
        /// <response code="200">List of vehicle fuels</response>
        /// <response code="400">There is some error while getting vehicle fuels. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/VehicleFuels")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalVehicleFuelsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<VehicleFuelViewModel>), description: "List of vehicle fuels")]
        public virtual IActionResult VehicleAppraisalVehicleFuelsGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<VehicleFuelViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<VehicleFuelViewModel>>(exampleJson)
                        : default(List<VehicleFuelViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Get all vehicle types</remarks>
        /// <response code="200">List of vehicle types</response>
        /// <response code="400">There is some error while getting vehicle types. Follow message instruction for more information</response>
        [HttpGet]
        [Route("/VehicleAppraisal/VehicleTypes")]
        [ValidateModelState]
        [SwaggerOperation("VehicleAppraisalVehicleTypesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<VehicleTypeViewModel>), description: "List of vehicle types")]
        public virtual IActionResult VehicleAppraisalVehicleTypesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<VehicleTypeViewModel>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n}, {\n  \"Description\" : \"Description\",\n  \"Code\" : 0\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<VehicleTypeViewModel>>(exampleJson)
                        : default(List<VehicleTypeViewModel>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
