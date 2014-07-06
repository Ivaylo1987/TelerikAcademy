define(["jquery"], function () {
		$.fn.combobox = function () {
			var $self = $(this);
			var $persons = $self.find(".person-item");
			var $selectedPerson = $self.find(".selectedPerson");
	
			// Hide all options
			$persons.hide();
	
			// Show all when click on already selected person
			$selectedPerson.on("click", function () {
				$persons.show();
			});
	
			// Select person on click
			$persons.on("click", function () {
				var $this = $(this);
				$selectedPerson.html($this.html());
				$persons.hide();
			})
						
			return $self;
		}
	
});