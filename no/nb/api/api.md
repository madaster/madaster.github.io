---
title: API
ref: api
menubar: none
---

# Madaster API
Endepunktet **Madaster API** kan brukes for å samhandle med Madaster-plattformen og ressursene på den.
Dette API-et dekker ennå ikke all funksjonalitet til plattformen, se [OpenAPI documentation](https://api.madaster.com/).

## Hold deg oppdatert
Abonner på nyhetsbrevet (på engelsk) for å motta viktige oppdateringer om APIet.
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
For å få tilgang til API-ressursene, trenger du et godkjenningstoken.
Hvis du ikke har ett ennå, se kapittelet om godkjenning nedenfor.
Dette tokenet skal sendes som en topptekst med navnet «X-API-Key», som vil autentisere forespørselen med tokenet.

## Godkjenning
For å få tilgang til ressursene i dette API-et, trenger du en API-nøkkel. Denne nøkkelen må knyttes til forespørselen i *X-API-Key*-toppteksten.
For å få tak i en API-nøkkel, må du legge til et token i Madaster-plattformen eller be kontoansvarlige om å gjøre dette for deg.
Dette vil gi deg tilgang til ressursene og deres tilhørende enheter.

### Legge til et token til en konto, mappe, bygning eller database
- Gå til ressurssiden og klikk på fanen *Brukere*

<img src="/assets/images/api/addtoken1NO.png" class="api-img"/>

- Klikk på knappen *Legg til API-token*

<img src="/assets/images/api/addtoken2NO.png" class="api-img"/>

- Angi et navn for dette tokenet, kopier den genererte nøkkelen (1), velg et tillatelsesnivå og utløpstid og avslutt ved å klikke på knappen Legg til (2)

<img src="/assets/images/api/addtoken3NO.png" class="api-img form-img"/>

## Versjoner
API-et forbedres hele tiden, så flere *versjoner* legges til grensesnittet etter som tiden går. Se [OpenAPI documentation](https://api.madaster.com/) for å finne ut hvilke versjoner som støtter hvilke API-kall. Det anbefales alltid å bruke nyeste tilgjengelige versjon for en API-forespørsel, men de gamle versjonene vil fortsatt være tilgjengelig i en viss tid til bruk med eldre utstyr. For å velge en API-versjon legger du til versjonstaggen på API-endepunktet. For versjon 3.0 må du for eksempel bruke https://api.madaster.com/api/v3.0

## Eksempler
I [Github-lageret](https://github.com/Madaster/examples) finner du noen eksempler på hvordan du samhandler med API-et i forskjellige programmeringsspråk.
