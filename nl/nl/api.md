---
title: API
ref: api
menubar: none
---

# Madaster API
Het **Madaster API** endpoint kan worden gebruikt voor interactie met het Madaster Platform en zijn bronnen.
Deze API dekt nog niet alle functionaliteit van het platform, raadpleeg hiervoor de [OpenAPI documentatie](https://api.madaster.com/).

## Blijf op de hoogte van updates
Door aan te melden op de API nieuwsbrief (in het Engels) blijft u op de hoogte van de laatste wijzigingen.
<!-- Begin Mailchimp Signup Form -->
<link href="//cdn-images.mailchimp.com/embedcode/classic-071822.css" rel="stylesheet" type="text/css">
<style type="text/css">
	#mc_embed_signup{background:#fff; clear:left; font:14px Helvetica,Arial,sans-serif;  width:600px;}
	/* Add your own Mailchimp form style overrides in your site stylesheet or in this style block.
	   We recommend moving this block and the preceding CSS link to the HEAD of your HTML file. */
</style>
<div id="mc_embed_signup">
    <form action="https://tech.us11.list-manage.com/subscribe/post?u=781d4269174ddb8c0dcf121fd&amp;id=d2e51fe3ef&amp;f_id=00028de0f0" method="post" id="mc-embedded-subscribe-form" name="mc-embedded-subscribe-form" class="validate" target="_blank" novalidate>
        <div id="mc_embed_signup_scroll">
        <h2>Subscribe to Madaster API updates</h2>
        <div class="indicates-required"><span class="asterisk">*</span> indicates required</div>
<div class="mc-field-group">
	<label for="mce-EMAIL">Email Address  <span class="asterisk">*</span>
</label>
	<input type="email" value="" name="EMAIL" class="required email" id="mce-EMAIL" required>
	<span id="mce-EMAIL-HELPERTEXT" class="helper_text"></span>
</div>
<div class="mc-field-group">
	<label for="mce-FNAME">First Name </label>
	<input type="text" value="" name="FNAME" class="" id="mce-FNAME">
	<span id="mce-FNAME-HELPERTEXT" class="helper_text"></span>
</div>
<div class="mc-field-group">
	<label for="mce-LNAME">Last Name </label>
	<input type="text" value="" name="LNAME" class="" id="mce-LNAME">
	<span id="mce-LNAME-HELPERTEXT" class="helper_text"></span>
</div>
	<div id="mce-responses" class="clear foot">
		<div class="response" id="mce-error-response" style="display:none"></div>
		<div class="response" id="mce-success-response" style="display:none"></div>
	</div>    <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
    <div style="position: absolute; left: -5000px;" aria-hidden="true"><input type="text" name="b_781d4269174ddb8c0dcf121fd_d2e51fe3ef" tabindex="-1" value=""></div>
        <div class="optionalParent">
            <div class="clear foot">
                <input type="submit" value="Subscribe" name="subscribe" id="mc-embedded-subscribe" class="button">
                <p class="brandingLogo"><a href="http://eepurl.com/h9i465" title="Mailchimp - email marketing made easy and fun"><img src="https://eep.io/mc-cdn-images/template_images/branding_logo_text_dark_dtp.svg"></a></p>
            </div>
        </div>
    </div>
</form>
</div>
<script type='text/javascript' src='//s3.amazonaws.com/downloads.mailchimp.com/js/mc-validate.js'></script><script type='text/javascript'>(function($) {window.fnames = new Array(); window.ftypes = new Array();fnames[0]='EMAIL';ftypes[0]='email';fnames[1]='FNAME';ftypes[1]='text';fnames[2]='LNAME';ftypes[2]='text';fnames[3]='ADDRESS';ftypes[3]='address';fnames[4]='PHONE';ftypes[4]='phone';fnames[5]='BIRTHDAY';ftypes[5]='birthday';}(jQuery));var $mcj = jQuery.noConflict(true);</script>
<!--End mc_embed_signup-->

## Token
Om toegang te krijgen tot de API, heeft u een autorisatie token nodig.
Als u deze nog niet heeft, zie dan het hoofdstuk over Autorisatie hieronder.
Het token moet worden verzonden als een header met de naam 'X-API-Key', om toegang te krijgen tot de gewenste bronnen.

## Autorisatie
Om toegang te krijgen tot de bronnen van deze API, heeft u een API token nodig. Dit token moet worden toegevoegd aan het verzoek in de *X-API-Key* header.
Om een API token te verkrijgen, dient u een token toe te voegen in het Madaster Platform, of uw account manager te vragen dit voor u te doen.
Dit geeft u toegang tot de middelen en de daaraan gekoppelde entiteiten.

### Add a token to a account, folder, building or database
- Ga naar de resource pagina en klik op het *Gebruikers* tabblad

<img src="/assets/images/api/addtoken1NL.png" class="api-img"/>

- Klik op de *API Token toevoegen* knop

<img src="/assets/images/api/addtoken2NL.png" class="api-img"/>

- Voer een naam in voor dit token, kopieer de gegenereerde sleutel (1), kies een toestemmingsniveau en een vervaltijd, en sluit af door te klikken op de knop Toevoegen (2)

<img src="/assets/images/api/addtoken3NL.png" class="api-img"/>

## Versions
De API wordt voortdurend verbeterd, dus naarmate de tijd vordert, worden meer *versies* aan de interface toegevoegd. Raadpleeg de [OpenAPI documentatie](https://api.madaster.com/) om te vinden welke versies welke API-aanroepen ondersteunen. Het wordt aangeraden om altijd de laatste beschikbare versie te gebruiken voor een API verzoek; maar de oude versies zullen nog enige tijd beschikbaar blijven voor legacy doeleinden. Om een API versie te selecteren, voeg de versie tag toe aan het API eindpunt. Voor versie 3.0 bijvoorbeeld, gebruik https://api.madaster.com/api/v3.0

## Examples
In de [Github repository](https://github.com/Madaster/examples) kunt u enkele voorbeelden vinden over hoe te communiceren met de API in verschillende programmeertalen.