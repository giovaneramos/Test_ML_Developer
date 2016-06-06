=begin
Desenvolvido por Giovane Pereira Ramos 
Telefone: (16) 99411-7744
Email: giovane_pr@hotmail.com
 
Destinado a empresa Fcamara	
=end

def greeting(time)
	if time.hour >=0 && time.hour <12
		sl = "Good morning! Today is "
	elsif time.hour >=12 && time.hour <=18
		sl = "Good afternoon! Today is "
	else
		sl = "Good evening! Today is "
		
	end
end

dt = Time.new 
print greeting(dt),dt.strftime("%d/%m/%Y %H:%M\n") 

def menu
	dt = Time.new
	minutes = 0 
	sl=" "
	
    loop do
    	
        puts "Select option below",
        	"1 - increment to minutes",
        	"2 - decrement to minutes",
        	"3 - EXIT"
        print "Option:"
		option = Integer(gets.chomp)
		if option == 3
			print "Bye!"
			exit!
		elsif option != 1 && option !=  2 
			puts "Invalid option: #{option} \n\n "
			menu
		end
		
		print "Insert minutes:"
		minutes = Integer(gets.chomp)
		
		if minutes < 0 
		minutes = minutes * -1
		end

       	case option
        when 1
            dt = dt +  minutes * 60
        when 2
            dt = dt -  minutes * 60
        end
        print greeting(dt),dt.strftime("%d/%m/%Y %H:%M\n\n") 
    end

end
menu